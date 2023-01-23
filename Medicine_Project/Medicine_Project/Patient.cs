using Medicine_Project.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Project
{
    public partial class Patient : Form
    {
        private int kNN = 3;
        bool isNN = true;
        NeuralNetwork model;
        KNearestNeighbor model2;
        public Patient()
        {
            InitializeComponent();
            Data.PatientForm = this;
            helloUserLabel.Text += " " + Data.User[1];
            isNN = NeuralNetworkButton.Checked;

            if (isNN == true) {
                model = new NeuralNetwork();
                model.Add(5, "relu");
                model.Add(5, "relu");
                model.Add(1, "sigmoid");
                model.Compile("mse", "adam", "accuracy");
                model.Normalize(Data.Temperatures);
                model.Fit(Data.Temperatures, 1000);
            }
            else
            {
                model2 = new KNearestNeighbor(kNN);
            }
            SetChart();
        }
        public override void Refresh()
        {
            SetChart();
        }

        private void SetChart()
        {
            double min = Data.UserTemperatures.Select(x => x[1]).ToList().ConvertAll(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).Min();
            double max = Data.UserTemperatures.Select(x => x[1]).ToList().ConvertAll(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).Max();
            min -= 0.2;
            max += 0.2;

            SetChartLabels(min, max);
            SetBars(min, max);
        }

        private void SetChartLabels(double min, double max)
        {         
            tempMinLabel.Text = min.ToString();
            tempMaxLabel.Text = max.ToString();
            tempAVGLabel.Text = ((min + max) / 2.0).ToString();
        }
        private void SetDate()
        {

        }

        private void SetBars(double min, double max)
        {
            var temperatures = Data.UserTemperatures.Select(x => x[1]).ToList();

            if(temperatures.Count <= 0) {
                return;
            }

            for (int i=0; i<9; i++)
            {
                var panelId = this.Controls.Find("panel" + (i + 1), true)[0];
                var labelId = this.Controls.Find("label" + (i), true)[0];

                int ninePlus = i;
                if (temperatures.Count >= 9)
                {
                    ninePlus += temperatures.Count - 9;

                    if( ninePlus >= 9 )
                    {
                        //var tmp = temperatures.ConvertAll(x => Convert.ToDouble(temperatures.GetRange(ninePlus - 9, ninePlus).ToList(), CultureInfo.InvariantCulture)));  
                        var tttemperatures = temperatures;
                        var ttninePlus = ninePlus;
                        var ttninePlus8 = ninePlus - 8;

                        var tmp = temperatures.GetRange(ninePlus - 8, 9).ToList();
                        var dtmp = tmp.ConvertAll(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).ToList();
                        var ftmp = dtmp.Select(x => (float)x).ToList();
                        float pred;
                        if (isNN)
                        {
                            pred = model.Predict(ftmp);
                        }
                        else
                        {
                            pred = Convert.ToSingle( model2.Predict(ftmp) );
                        }

                        if (pred > 0.5f)
                        {
                            panelId.BackColor = SystemColors.HotTrack;                            
                        }
                        else
                        {
                            panelId.BackColor = Color.IndianRed;
                        }
                    }
                }


                if (i < temperatures.Count)
                {
                    double temp = Convert.ToDouble(temperatures[ninePlus], CultureInfo.InvariantCulture);
                    double heightPercent = (temp - min) / (max - min);          
                    panelId.Height = (int)(heightPercent * 180);
                    panelId.Location = new Point(panelId.Location.X, 16);
                    panelId.Location = new Point(panelId.Location.X, panelId.Location.Y + 180 - panelId.Height);
                    
                    labelId.Text = Data.UserTemperatures.Select(x => x[2]).ToList()[ninePlus].ToString().Remove(5);
                    //this.Controls.Find("panel" + (i+1), true)[0].Height = (int)(heightPercent * 180);
                }
                else
                {                    
                    panelId.Height = 0;
                }
            }
        }

        private void AddTmpButton_Click(object sender, EventArgs e)
        {
            new AddTemperature().Show();
        }

        private void helloUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountMenuPanel.Visible = !AccountMenuPanel.Visible;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KNNComboBox != null)
            {
                kNN = KNNComboBox.SelectedIndex + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Data.form1.Show();
            Data.User.Clear();
            Data.ReadUsers();
            this.Close();
        }

        private void NeuralNetworkButton_CheckedChanged(object sender, EventArgs e)
        {
            isNN = true;
        }

        private void KNearestNeighborsButton_CheckedChanged(object sender, EventArgs e)
        {
            isNN = false;
        }
    }
}
