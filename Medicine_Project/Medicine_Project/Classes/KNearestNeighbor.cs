using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Project.Classes
{
    internal class KNearestNeighbor : NeuralNetwork
    {
        private readonly int kNN;
        public KNearestNeighbor(int k = 3) 
        {
            this.kNN = k;
        }

        public List<float> GenerateRandomTemperatures()
        {
            Random random = new Random();
            List<float> temperatures = new List<float>();

            for(int i=0; i<9; i++) {
                temperatures.Add( (float)random.NextDouble() * 0.2f + 36.5f );
            }
            
            return temperatures;
        }

        public bool Predict(List<float> temperatures)
        {

            if (temperatures.Count <= 0) 
            {
                throw new ArgumentNullException();
            }

            List<List<float>> trainingData = new(Data.Temperatures);
            List<bool> trainingOutput = new(Data.Diagnosis);

            List<bool> diagnosis = new List<bool>();

            int rowToRemove = 0;

            for (int k = 0; k < kNN; k++)
            {
                double? bestDistance = null;
                bool diagnose = false;

                for (int row = 0; row < trainingData.Count; row++)
                {
                    double tmpDistance = 0;
                    for (int i = 0; i < temperatures.Count; i++)
                    {
                        tmpDistance += Math.Pow((temperatures[i] - trainingData[row][i]), 2);
                    }

                    if (bestDistance == null || tmpDistance < bestDistance)
                    {
                        bestDistance = tmpDistance;
                        diagnose = trainingOutput[row];
                        rowToRemove = row;
                    }
                }
                diagnosis.Add(diagnose);
                trainingData.RemoveAt(rowToRemove);
                trainingOutput.RemoveAt(rowToRemove);
            }

            /*Debug.Print("----------------");
            Debug.Print(trainingData.Count.ToString());
            Debug.Print(trainingOutput.Count.ToString());
            Debug.Print(Data.Temperatures.Count.ToString());
            Debug.Print(Data.Diagnosis.Count.ToString());

            /*for (int i = 0; i < diagnosis.Count; i++)
            {
                Debug.Print(diagnosis[i].ToString());
            }
            Debug.Print("----------------");*/

            int diagnosisSum = diagnosis.Select(x => Convert.ToInt32(x)).Sum();

            if (diagnosisSum > kNN / 2)
                return true;
            return false;
        }
    }
}
