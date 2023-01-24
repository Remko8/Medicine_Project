using Medicine_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine_Project
{
    public partial class AddTemperature : Form
    {
        DateTime lastDate;
        public AddTemperature()
        {
            InitializeComponent();
            string lastDateS = Data.UserTemperatures[Data.UserTemperatures.Count - 1][2] + " " + Data.UserTemperatures[Data.UserTemperatures.Count - 1][3];
            //DateTime date = new DateTime(2008, 6, 1, 7, 47, 0);
            lastDate = DateTime.ParseExact(lastDateS, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTXT.Text = lastDate.AddDays(1).ToString("dd.MM.yyyy");
            TimeTXT.Text = DateTime.Now.ToString("HH:mm");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime;
            if (!DateTime.TryParse(DateTXT.Text, out dateTime) || !DateTime.TryParse(TimeTXT.Text, out dateTime))
            {
                MessageBox.Show("Incorrect Date format");
                return; 
            }
            string line = Data.User[0] + "," + TempTXT.Text + "," + DateTXT.Text + "," + TimeTXT.Text;
            line = Data.AllUsersTemperatures.Count > 0 ? Environment.NewLine + line : line;
            File.AppendAllText(Data.filePathTemperatures, line);
            Data.ReadTemperatures();
            Data.PatientForm?.Refresh();
            this.Close();            
        }

        private void BackButtonAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemperatureSlider_Scroll(object sender, EventArgs e)
        {
            var val = (TemperatureSlider.Value / 100.0).ToString();
            var parse = double.Parse(val);
            TempTXT.Text = parse.ToString(CultureInfo.InvariantCulture);
        }

        private void TempTXT_TextChanged(object sender, EventArgs e)
        {
            var val = (int)(Convert.ToDouble(TempTXT.Text, CultureInfo.InvariantCulture) * 100);
            if (val > TemperatureSlider.Maximum)
            {
                val = TemperatureSlider.Maximum;
            }
            if(val < TemperatureSlider.Minimum)
            {
                val = TemperatureSlider.Minimum;
            }

            TemperatureSlider.Value = val;
        }
    }
}
