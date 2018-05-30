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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Boolean Validate()
        {
            Boolean valid = true;

            if(userNameInfo == null || userPasswordInfo.Length < 4)
            {
                valid = false;
            }
            else if(userPasswordInfo == null || userPasswordInfo.Length < 6)
            {
                valid = false;
            }
            return valid;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        String userNameInfo;
        String userPasswordInfo;

        private void userName_OnValueChanged(object sender, EventArgs e)
        {
            userNameInfo = userName.Text;
        }

        private void userPassword_OnValueChanged(object sender, EventArgs e)
        {
            userPasswordInfo = userPassword.Text;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                MessageBox.Show("Por favor ingrese sus datos correctamente");
            }
            else
            {
                this.Hide();
                Reproducer reproducer = new Reproducer();
                reproducer.Show();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }
}
