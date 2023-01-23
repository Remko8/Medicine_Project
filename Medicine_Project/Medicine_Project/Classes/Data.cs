using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Project.Classes
{
    static class Data
    {
        // WINDOWS

        public static Form? PatientForm;
        public static Form? form1;

        // TRAINING DATA

        static public List<bool> Diagnosis = new List<bool>();
        static public List<List<float>> Temperatures = new List<List<float>>();

        static public void ReadTrainingData()
        {
            byte[] DataFile;
            string filePathData = @"../../../../../est-prog.dat";

            if (File.Exists(filePathData))
            {
                Diagnosis.Clear();
                Temperatures.Clear();

                int row = 0;
                Temperatures.Add(new List<float>());

                DataFile = File.ReadAllBytes(filePathData);
                for (int i = 0; i < DataFile.Count(); i += 4)
                {
                    Byte[] arr = new[] { DataFile[i], DataFile[i + 1], DataFile[i + 2], DataFile[i + 3] };
                    if ((i + 4) % 40 != 0)
                    {
                        Temperatures[row].Add(MathF.Round(BitConverter.ToSingle(arr), 2));
                    }
                    else
                    {
                        Diagnosis.Add(BitConverter.ToBoolean(arr));
                        Temperatures.Add(new List<float>());
                        row++;
                    }
                }
                Temperatures.RemoveAt(Temperatures.Count() - 1); // removing last row because its always empty
            }
            else
            {
                MessageBox.Show("DataFile failed to load");
            }
        }


        // USERS

        public static List<List<string>> Users = new List<List<string>>();
        public static string filePath = @"../../../DataBase/Users.txt";
        public static void ReadUsers()
        {
            if (File.Exists(filePath))
            {
                Users.Clear();
                string[] UsersFile = File.ReadAllLines(filePath);
                foreach (string line in UsersFile)
                {
                    Users.Add(line.Split(',').ToList());
                }
            }
            else
            {
                MessageBox.Show("Cannot connect to server(Users)");
            }
        }

        // ACTIVE USER
        public static List<string> User = new List<string>();
        public static List<List<string>> UserTemperatures = new List<List<string>>();
        public static List<List<string>> AllUsersTemperatures = new List<List<string>>();
        public static string filePathTemperatures = @"../../../DataBase/UserTemperatures.txt";

        public static void ReadTemperatures()
        {            
            if (File.Exists(filePathTemperatures))
            {
                AllUsersTemperatures.Clear();
                string[] temperaturesFile = File.ReadAllLines(filePathTemperatures);
                foreach (string line in temperaturesFile)
                {
                    AllUsersTemperatures.Add(line.Split(',').ToList());
                }
            }
            else
            {
                MessageBox.Show("Cannot read temperatures");
            }

            UserTemperatures = AllUsersTemperatures.Where(x => x[0] == User[0]).ToList();
        }
    }
}
