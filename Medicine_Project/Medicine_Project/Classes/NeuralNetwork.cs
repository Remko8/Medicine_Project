using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Project.Classes
{
    internal class NeuralNetwork : MachineLearning
    {
        List<Layer> layers = new();
        private class Layer
        {
            public int neurons;
            private string activation;

            public List<float> inputs = new();
            public List<List<float>> weights = new();

            private Random rand = new Random();
            // private double bias;

            public Layer(int neurons, string activation)
            {
                this.neurons = neurons;
                this.activation = activation;

                inputs.Add(1); // bias

            }
        }

        public NeuralNetwork()
        {

        }

        public void Add(int neurons, string activation = "relu")
        {
            layers.Add(new Layer(neurons, activation));
        }

        public void Normalize(List<List<float>> data)
        {
            List<float> maxs = new List<float>(new float[data[0].Count - 1]);



            for (int i = 0; i < data[0].Count - 1; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    maxs[i] = maxs[i] > data[j][i] ? maxs[i] : data[j][i];
                }
            }

            List<float> mins = maxs.Select(x => x).ToList();
            for (int i = 0; i < data[0].Count - 1; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    mins[i] = mins[i] < data[j][i] ? mins[i] : data[j][i];
                }
            }


            for (int i = 0; i < data[0].Count - 1; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    Data.Temperatures[j][i] = (Data.Temperatures[j][i] - mins[i]) / (maxs[i] - mins[i]);
                }
            }

            /*for (int i = 0; i < data[0].Count - 1; i++)
            {
                for (int j = 0; j < Data.Diagnosis.Count; j++)
                {
                    Data.Diagnosis[j][i] = (Data.Diagnosis[j][i] - mins[i]) / (maxs[i] - mins[i]);
                }
            }*/
        }

        public void Compile(string loss, string optimizer, string metric)
        {
            Random rand = new Random();

            for (int l = 0; l < layers.Count; l++)
            {
                if (l > 0)
                {
                    for (int j = 0; j < layers[l - 1].weights.Count; j++)
                    {
                        layers[l].inputs.Add(0);
                    }
                }


                for (int i = 0; i < layers[l].neurons; i++)
                {
                    layers[l].weights.Add(new List<float>());
                    if (l > 0)
                    {
                        for (int j = 0; j < layers[l - 1].neurons + 1; j++) // +1 for bias
                        {
                            layers[l].weights[i].Add(rand.NextSingle());
                        }
                    }
                    else
                    {
                        for (int j = 0; j < layers[l].neurons + 1; j++) // +1 for bias
                            layers[l].weights[i].Add(rand.NextSingle());
                    }
                }
            }
        }

        public void Fit(List<List<float>> data, int epochs, bool shuffle = false, float validationSplit = 0.2f)
        {
            int epoch = 1;
            var oldWeights = layers[2].weights.Select(x => x).ToList(); ;
            while (epoch <= epochs)
            {
                epoch++;

                for (int t = 0; t < data.Count; t++)
                {
                    var dataRow = data[t];

                    layers[0].inputs.Clear();
                    layers[0].inputs.Add(1);
                    layers[0].inputs.AddRange(dataRow);
                    layers[0].inputs.RemoveAt(dataRow.Count);

                    // --------------------
                    // list init
                    List<List<float>> eska = new List<List<float>>();
                    eska.Add(new List<float>(new float[6]));
                    eska.Add(new List<float>(new float[6]));
                    eska.Add(new List<float>(new float[1]));

                    /*for (int l = 0; l < layers.Count; l++)
                    {
                        eska.Add(new List<double>(new double[layers[l].weights.Count]));
                    }*/

                    List<List<float>> sigma = eska.Select(x => x.ToList()).ToList();

                    var test1 = layers[0].inputs;
                    var test2 = layers[1].inputs;
                    var test3 = layers[2].inputs;
                    var test4 = dataRow;


                    List<float> prediction = new List<float>();

                    for (int l = 0; l < layers.Count; l++)
                    {
                        for (int i = 0; i < layers[l].weights.Count; i++)
                        {
                            for (int j = 0; j < layers[l].inputs.Count; j++)
                            {
                                eska[l][i] += layers[l].inputs[j] * layers[l].weights[i][j];
                            }
                            if (l == layers.Count - 1)
                            {
                                var result = Sigmoid(-eska[l][i]);
                                prediction.Add(Sigmoid(-eska[l][i]));
                            }
                            else
                            {
                                layers[l + 1].inputs[i + 1] = Sigmoid(-eska[l][i]);
                            }
                        }
                    }
                    // do poprawy dla wielu class
                    int size = layers.Count - 1;
                    float error = dataRow[dataRow.Count - 1] - prediction[0]; // data[t][ -1]
                    float derivative = Sigmoid(-eska[size][0]) * (1 - Sigmoid(-eska[size][0]));
                    sigma[size][0] = error * derivative;

                    // testy
                    var x = -eska[size][0];
                    var pow = MathF.Pow(MathF.E, x);
                    var pow1 = pow + 1.0f;
                    var pow2 = 1.0f / pow1;
                    var ss1 = 1.0f / (1.0f + MathF.Pow(MathF.E, x));
                    var ss2 = 1.0f - (1.0f / (1.0f + MathF.Pow(MathF.E, x)));
                    var s1 = 1.0f / (1.0f + MathF.Exp(x));
                    var s2 = 1.0f - (1.0f / (1.0f + MathF.Exp(x)));
                    float derivativeeee = ss1 * ss2;
                    var sigmaaa = error * derivative;
                    ;
                    // ----------

                    /*
                    for (int l = size; l > 0; l--)
                    {
                        List<double> errorList = new List<double>();
                        List<double> derivativeList = new List<double>();

                        for (int n = 0; n < layers[l].neurons; n++)                            
                        {
                            double error_ = 0;
                            for (int i = 0; i < layers[l].inputs.Count; i++)
                            {
                                error_ += sigma[l][n] * layers[l].weights[n][i];
                            }
                            errorList.Add(error_);
                            var derivativeTest = Sigmoid(-eska[l - 1][n]);
                            derivative = Sigmoid(-eska[l-1][n]) * (1 - Sigmoid(-eska[l-1][n]));
                            derivativeList.Add(derivative);

                            sigma[l-1][n] = errorList[n] * derivativeList[n];
                        }
                    }
                    */
                    /// TEST >>>
                    /*for (int l = size; l > 0; l--)
                    {
                        List<double> errorList = new List<double>();
                        List<double> derivativeList = new List<double>();

                        for (int i = 0; i < layers[l].inputs.Count; i++)                            
                        {
                            double error_ = 0;
                            for (int n = 0; n < layers[l].weights.Count; n++)
                            {
                                error_ += sigma[l][n] * layers[l].weights[n][i];
                            }
                            errorList.Add(error_);
                            var derivativeTest = Sigmoid(-eska[l - 1][i]);
                            derivative = Sigmoid(-eska[l - 1][i]) * (1 - Sigmoid(-eska[l - 1][i]));
                            derivativeList.Add(derivative);

                            sigma[l - 1][i] = errorList[i] * derivativeList[i];
                        }
                    }*/
                    /// TEST <<<

                    /// TEST2 >>>

                    //second layer            
                    List<float> error2 = new List<float>();
                    List<float> derivative2 = new List<float>();


                    for (int i = 0; i < layers[2].inputs.Count; i++)
                    {
                        float error_ = sigma[2][0] * layers[2].weights[0][i];
                        error2.Add(error_);

                        derivative = Sigmoid(-eska[1][i]) * (1 - Sigmoid(-eska[1][i]));
                        derivative2.Add(derivative);

                        sigma[1][i] = error2[i] * derivative2[i];
                    }

                    List<float> errorList = new List<float>();
                    List<float> derivativeList = new List<float>();

                    for (int i = 0; i < layers[1].inputs.Count; i++)
                    {
                        float error_ = 0;
                        for (int n = 0; n < layers[1].weights.Count; n++)
                        {
                            error_ += sigma[1][n] * layers[1].weights[n][i];
                        }
                        errorList.Add(error_);
                        var derivativeTest = Sigmoid(-eska[0][i]);
                        derivative = Sigmoid(-eska[0][i]) * (1 - Sigmoid(-eska[0][i]));
                        derivativeList.Add(derivative);

                        sigma[0][i] = errorList[i] * derivativeList[i];
                    }
                    /// TEST2 <<<


                    var oldWeights_ = layers[2].weights;

                    // weights
                    for (int l = 0; l < layers.Count; l++)
                    {
                        for (int n = 0; n < layers[l].weights.Count; n++)
                        {
                            for (int i = 0; i < layers[l].inputs.Count; i++)
                            {
                                layers[l].weights[n][i] = layers[l].weights[n][i] + 0.2f * sigma[l][n] * layers[l].inputs[i];
                            }
                        }
                    }
                    var newWeights_ = layers[2].weights;
                }
            }
            var newWeights = layers[2].weights.Select(x => x).ToList();
        }

        public void FitOld(List<List<float>> data, int epochs, bool shuffle = false, float validationSplit = 0.2f)
        {
            var oldWeights = layers[2].weights;
            for (int e = 0; e < epochs; e++)
            {
                for (int t = 0; t < data.Count; t++)
                {
                    var dataRow = data[t];

                    layers[0].inputs.Clear();
                    layers[0].inputs.Add(1);
                    layers[0].inputs.AddRange(dataRow); // later data[t]
                    layers[0].inputs.RemoveAt(dataRow.Count);

                    int epoch = 1;

                    // --------------------
                    // list init
                    List<List<float>> s = new List<List<float>>();

                    for (int l = 0; l < layers.Count; l++)
                    {
                        s.Add(new List<float>(new float[layers[l].inputs.Count - 1]));
                    }

                    List<List<float>> sigma = new(s);

                    var test1 = layers[0].inputs;
                    var test2 = layers[1].inputs;
                    var test3 = layers[2].inputs;
                    var test4 = dataRow;


                    List<float> prediction = new List<float>();

                    for (int l = 0; l < layers.Count; l++)
                    {
                        for (int i = 0; i < layers[l].weights.Count; i++)
                        {
                            for (int j = 0; j < layers[l].inputs.Count; j++)
                            {
                                s[l][i] += layers[l].inputs[j] * layers[l].weights[i][j];
                            }
                            if (l == layers.Count - 1)
                            {
                                var result = Sigmoid(-s[l][i]);
                                prediction.Add(Sigmoid(-s[l][i]));
                            }
                            else
                            {
                                layers[l + 1].inputs[i + 1] = reLu(s[l][i]);
                            }
                        }
                    }

                    // --------------------
                    // later: error => error[t];            
                    // - List<List<double>> sigma = new(eska);
                    // - sigma = sigma.Select(x => x.Select(z => 0.0).ToList()).ToList();

                    // third layer
                    //double prediction = Convert.ToDouble(Predict(data));


                    float error = dataRow[dataRow.Count - 1] - prediction[0]; // data[t][ -1]
                    float derivative = Sigmoid(-s[2][0]) * (1 - Sigmoid(-s[2][0]));
                    sigma[2][0] = error * derivative;

                    //second layer            
                    List<float> error2 = new List<float>();
                    List<float> derivative2 = new List<float>();


                    for (int i = 0; i < layers[2].inputs.Count; i++)
                    {
                        error = sigma[2][0] * layers[2].weights[0][i];
                        error2.Add(error);

                        //derivative = Sigmoid(-s[1][i]) * (1 - Sigmoid(-s[1][i]));
                        derivative = reLuDerivative(s[1][i]);
                        derivative2.Add(derivative);

                        sigma[1][i] = error2[i] * derivative2[i];
                    }

                    //first layer
                    List<float> error3 = new List<float>();
                    List<float> derivative3 = new List<float>();

                    for (int i = 0; i < layers[1].inputs.Count; i++)
                    {
                        error = 0;
                        for (int n = 0; n < layers[1].weights.Count; n++)
                        {
                            error += sigma[1][n] * layers[1].weights[n][i];
                        }
                        error3.Add(error);

                        //derivative = Sigmoid(-s[0][i]) * (1 - Sigmoid(-s[0][i]));
                        derivative = reLuDerivative(s[1][i]);
                        derivative3.Add(derivative);

                        sigma[0][i] = error3[i] * derivative3[i];
                    }

                    var oldWeights_ = layers[2].weights;

                    // weights
                    for (int l = 0; l < layers.Count; l++)
                    {
                        for (int n = 0; n < layers[l].weights.Count; n++)
                        {
                            for (int i = 0; i < layers[l].inputs.Count; i++)
                            {
                                layers[l].weights[n][i] = layers[l].weights[n][i] + 0.2f * sigma[l][n] * layers[l].inputs[i];
                            }
                        }
                    }
                    var newWeights_ = layers[2].weights;
                }
            }
            var newWeights = layers[2].weights;
        }

        public float Predict(List<float> data)
        {
            layers[0].inputs.Clear();
            layers[0].inputs.Add(1);
            layers[0].inputs.AddRange(data);

            float prediction = -1f;

            for (int l = 0; l < layers.Count; l++)
            {
                float[] s = new float[layers[l].weights.Count];
                for (int n = 0; n < layers[l].weights.Count; n++)
                {
                    for (int j = 0; j < layers[l].inputs.Count; j++)
                    {
                        s[n] += layers[l].inputs[j] * layers[l].weights[n][j];
                    }
                    if (l == layers.Count - 1)
                    {
                        var result = Sigmoid(-s[n]);
                        prediction = result;
                    }
                    else
                    {
                        // var newInput = Sigmoid(-s[n]);
                        layers[l + 1].inputs[n + 1] = reLu(s[n]); // inputs[i+1] bcs i=0 is for bias (better to add bias at the end?)
                    }

                    var ttest = s;
                }
            }

            return prediction;
        }

        private float Sigmoid(float x)
        {
            return 1.0f / (1.0f + MathF.Exp(x));
        }

        private float reLuDerivative(float x)
        {
            if (x > 0)
            {
                return 1;
            }
            return 0.0f;
        }

        private float reLu(float x)
        {
            if (x > 0)
            {
                return x;
            }
            return 0.0f;
        }
    }
}
