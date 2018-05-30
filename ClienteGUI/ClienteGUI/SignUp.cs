using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteGUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        

        public Boolean Validate()
        {
            Boolean valid = true;

            if (fullName == null || fullName.Length < 8)
            {
                valid = false;
            }
            else if(userName == null || userName.Length < 4)
            {
                valid = false;
            }
            else if(userAge == null || userAge < 12)
            {
                valid = false;
            }
            else if(userPassword == null || userPassword.Length < 6)
            {
                valid = false;
            }
            else if(userPasswordRe == null || !userPasswordRe.Equals(userPassword))
            {
                valid = false;
            }

            return valid;
        }

        String fullName;
        String userName;
        int userAge;
        String userPassword;
        String userPasswordRe;

        private SimpleLL<String> fullNames = new SimpleLL<String>();
        private SimpleLL<String> usersNames = new SimpleLL<String>();
        private SimpleLL<int> usersAges = new SimpleLL<int>();
        private SimpleLL<String> usersPasswords = new SimpleLL<String>();


        private void nameInfo_OnValueChanged(object sender, EventArgs e)
        {
            fullName = nameInfo.Text;
        }

        private void userNameInfo_OnValueChanged(object sender, EventArgs e)
        {
            userName = userNameInfo.Text;
        }

        private void userEmailInfo_OnValueChanged(object sender, EventArgs e)
        {
            userAge = Int32.Parse(userEmailInfo.Text);
        }

        private void userPasswordInfo_OnValueChanged(object sender, EventArgs e)
        {
            userPassword = userPasswordInfo.Text;
        }

        private void userPasswordInfoEvaluation_OnValueChanged(object sender, EventArgs e)
        {
            userPasswordRe = userPasswordInfoEvaluation.Text;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                MessageBox.Show("Reingrese sus datos de nuevo");
            }
            else
            {
                fullNames.Add(userName);
                usersAges.Add(userAge);
                usersNames.Add(userName);
                usersPasswords.Add(userPassword);

                this.Hide();
                LogIn logIn = new LogIn();

                logIn.Show();
            }
        }
    }
}