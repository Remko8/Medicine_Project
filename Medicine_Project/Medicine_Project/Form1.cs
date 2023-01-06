using Microsoft.VisualBasic.ApplicationServices;

namespace Medicine_Project
{
    public partial class Form1 : Form
    {

        public static List<List<string>> Users = new List<List<string>>();
        string filePath = @"../../../DataBase/Users.txt";

        public Form1()
        {
            ReadUsers();
            InitializeComponent();
        }

        private void ReadUsers()
        {            
            if (File.Exists(filePath))
            {
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
            foreach (List<String> user in Users)
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
            string line = FirstNameTXT.Text + "," + SecondNameTXT.Text + "," + UsernameTXT.Text + "," + PasswordTXT.Text + "," + "patient" + "," + EmailTXT.Text;
            line = Users.Count > 0 ? Environment.NewLine + line : line;
            File.AppendAllText(filePath, line);
            SignUpPanel.Hide();
            AcceptButton = SignInButton;

            ReadUsers();

            FirstNameTXT.Clear();
            SecondNameTXT.Clear();
            UsernameTXT.Clear();
            PasswordTXT.Clear();
            EmailTXT.Clear();
            UsernameTextBox.Focus();
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
            int usernameId =  Users.FindIndex(x => x[2] == UsernameFPTXT.Text);
            int emailId = Users.FindIndex(x => x[5] == EmailFPTXT.Text);

            if (usernameId == emailId)
            {
                Users[usernameId][3] = NewPasswordTXT.Text;

                File.WriteAllText(filePath, "");

                foreach (var line in Users)
                {
                    var result = String.Join(",", line.ToArray());
                    File.AppendAllText(filePath, result);
                }

                ReadUsers();
            }
            ForgetPasswordPanel.Hide();
            AcceptButton = SignInButton;
            UsernameTextBox.Focus();
        }
    }
}