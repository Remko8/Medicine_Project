using Medicine_Project.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace Medicine_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Data.ReadUsers();
            Data.ReadTrainingData();


            // >>> testing KNearestNeighbor
            List<bool> diagnosis = new List<bool>();
            int n = 300;
            var model = new KNearestNeighbor(3);


            for (int i = 0; i < n; i++)
            {
                diagnosis.Add(model.Predict(model.GenerateRandomTemperatures()));
            }

            /*for (int i = 0; i < n; i++)
                if (diagnosis[i]==true) 
                    Debug.Print(diagnosis[i].ToString());*/

            Debug.Print("TRUE = " + diagnosis.Count(x=>x==true).ToString());
            Debug.Print("FALSE = " + diagnosis.Count(x => x == false).ToString());
            // <<< end of test
        }

        bool mousedown;
        private Point offset;

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            foreach (List<String> user in Data.Users)
            {
                if (UsernameTextBox.Text == user[2] && PasswordTextBox.Text == user[3])
                {
                    if (user[4] == "doctor")
                    {
                        new Doctor().Show();                        
                    }
                    else if(user[4] == "patient")
                    {
                        new Patient().Show();
                    }
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Incorrect username or password");
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            UsernameTextBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.Show();
            AcceptButton = SignUppedButton;
            FirstNameTXT.Focus();
        }     

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.Hide();
            AcceptButton = SignInButton;
            UsernameTextBox.Focus();
        }

        private void SignUppedButton_Click(object sender, EventArgs e)
        {
            if (!SignUpValidation())
            {                
                return;
            }

            string line = FirstNameTXT.Text + "," + SecondNameTXT.Text + "," + UsernameTXT.Text + "," + PasswordTXT.Text + "," + "patient" + "," + EmailTXT.Text;
            line = Data.Users.Count > 0 ? Environment.NewLine + line : line;
            File.AppendAllText(Data.filePath, line);
            SignUpPanel.Hide();
            AcceptButton = SignInButton;

            Data.ReadUsers();

            FirstNameTXT.Clear();
            SecondNameTXT.Clear();
            UsernameTXT.Clear();
            PasswordTXT.Clear();
            EmailTXT.Clear();
            UsernameTextBox.Focus();

        }

        private bool SignUpValidation()
        {
            if (Data.Users.Select(x => x[2]).Contains(UsernameTXT.Text) || Data.Users.Select(x => x[3]).Contains(PasswordTXT.Text))
            {
                MessageBox.Show("This account already exists");
                return false;
            }

            if (Data.Users.Select(x => x[5]).Contains(EmailTXT.Text))
            {
                MessageBox.Show("This e-mail has been already used");
                return false;
            }

            if (FirstNameTXT.Text.Length < 1  && SecondNameTXT.Text.Length < 1 && UsernameTXT.Text.Length < 6 && PasswordTXT.Text.Length < 6 && EmailTXT.Text.Length < 8)
            {
                MessageBox.Show("Fields cannot be empty or too short");
                return false;
            }

            return true;
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordPanel.Show();
            AcceptButton = ChangePasswordButton;
            UsernameFPTXT.Focus();
        }

        private void BackButtonFP_Click(object sender, EventArgs e)
        {
            ForgetPasswordPanel.Hide();
            AcceptButton = SignInButton;
            UsernameTextBox.Focus();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            int usernameId =  Data.Users.FindIndex(x => x[2] == UsernameFPTXT.Text);
            int emailId = Data.Users.FindIndex(x => x[5] == EmailFPTXT.Text);

            if (usernameId == emailId && usernameId != -1)
            {
                Data.Users[usernameId][3] = NewPasswordTXT.Text;

                File.WriteAllText(Data.filePath, "");

                foreach (var line in Data.Users)
                {
                    var result = String.Join(",", line.ToArray());
                    File.AppendAllText(Data.filePath, result);
                }

                Data.ReadUsers();

                ForgetPasswordPanel.Hide();
                AcceptButton = SignInButton;
                UsernameTextBox.Focus();
            }
            MessageBox.Show("User not found");
        }
    }
}