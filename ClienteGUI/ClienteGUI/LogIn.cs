using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;

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

        private String GetOrignalPassword(String passwordMD5)
        {
            MD5CryptoServiceProvider userMD5Password = new MD5CryptoServiceProvider();
            userMD5Password.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwordMD5));
            byte[] result = userMD5Password.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
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

        XmlDocument userInfoLoad = new XmlDocument();

        private void logInButton_Click(object sender, EventArgs e)
        {
            userInfoLoad.Load(@"C:\\Users\jonat\\OneDrive\\Jonathan\\Trabajos TEC\\Computadores\\Algoritmos y Estructura de Datos I\\Eclipse-Workspace\\Odyssey\\ClienteGUI\\UsersInfo.xml");
            XmlNode userNameLoad = userInfoLoad.SelectSingleNode("//Details/UserName/text()");
            XmlNode userPasswordLoad = userInfoLoad.SelectSingleNode("//Details/UserPassword/text()");
            String userPasswordDecrypted = GetOrignalPassword(userPasswordLoad.Value);
            String userPasswordEncrypted = GetOrignalPassword(userPasswordInfo);

            if ((userNameInfo != userNameLoad.Value) || (userPasswordEncrypted != userPasswordLoad.Value))
            {
                //MessageBox.Show("Por favor ingrese sus datos correctamente");
                MessageBox.Show(userPasswordDecrypted);
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
