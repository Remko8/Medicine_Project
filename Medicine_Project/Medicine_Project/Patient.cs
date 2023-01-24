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
            KValComboBox.SelectedIndex = 2;
            Data.PatientForm = this;
            helloUserLabel.Text += " " + Data.User[1];
            isNN = NeuralNetworkButton.Checked;

            //if (isNN == true) {
            model = new NeuralNetwork();
            model.Add(9, "sigmoid");
            model.Add(9, "sigmoid");
            model.Add(1, "sigmoid");
            model.Compile("mse", "adam", "accuracy");
            model.Normalize(Data.Temperatures);
            model.Fit(Data.Temperatures, 10000);
            // }
            // else
            //{
            model2 = new KNearestNeighbor(kNN);
            // }
            SetChart();
        }
        public override void Refresh()
        {
            SetChart();
        }

        private void SetChart()
        {
            double min = 35;
            double max = 38;

            if (Data.UserTemperatures.Count > 0)
            {
                int range = Data.UserTemperatures.Count > 9 ? 9 : Data.UserTemperatures.Count;
                min = Data.UserTemperatures.GetRange(Data.UserTemperatures.Count - range, range).Select(x => x[1]).ToList().ConvertAll(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).Min();
                max = Data.UserTemperatures.GetRange(Data.UserTemperatures.Count - range, range).Select(x => x[1]).ToList().ConvertAll(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).Max();
                min -= 0.1;
                max += 0.1;
            }

            SetChartLabels(min, max);
            SetBars(min, max);
        }

        private void SetChartLabels(double min, double max)
        {
            tempMinLabel.Text = Math.Round(min, 2).ToString();
            tempMaxLabel.Text = Math.Round(max, 2).ToString();
            tempAVGLabel.Text = Math.Round(((min + max) / 2.0), 2).ToString();
        }

        private void SetBars(double min, double max)
        {
            var temperatures = Data.UserTemperatures.Select(x => x[1]).ToList();

            if (temperatures.Count < 0)
            {
                return;
            }

            for (int i = 0; i < 9; i++)
            {
                var panelId = this.Controls.Find("panel" + (i + 1), true)[0];
                var labelId = this.Controls.Find("label" + (i), true)[0];

                int ninePlus = i;
                if (temperatures.Count >= 9)
                {
                    ninePlus += temperatures.Count - 9;

                    if (ninePlus >= 9)
                    {
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
                            var predBool = model2.Predict(ftmp);
                            pred = predBool ? 1 : 0;
                        }
                        predictLabel.Text = pred.ToString(CultureInfo.InvariantCulture);

                        if (pred > 0.75f)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Data.form1?.Show();
            Data.User.Clear();
            Data.ReadUsers();
            this.Refresh();
            Data.form1?.Refresh();
            this.Close();
        }

        private void NeuralNetworkButton_CheckedChanged(object sender, EventArgs e)
        {
            isNN = true;
            Data.PatientForm?.Refresh();

        }

        private void KNearestNeighborsButton_CheckedChanged(object sender, EventArgs e)
        {
            isNN = false;
            Data.PatientForm?.Refresh();
        }

        private void tempMinLabel_Click(object sender, EventArgs e)
        {

        }

        private void KValComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KValComboBox != null)
            {
                kNN = KValComboBox.SelectedIndex + 1;
                model2 = new KNearestNeighbor(kNN);
                Data.PatientForm?.Refresh();
            }
        }
    }
}
