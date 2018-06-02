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
        /**
         * Método que incia la clase.
         * */
        public LogIn()
        {
            InitializeComponent();
        }

        /**
         * Método que se encarga de asignar la función de apagado al botón de apagado.
         * */
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Método que se encarga de encriptar la clave que ingresa el usuario para su comprobación al iniciar sesión.
         * */
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

        /**
         * Método que se encarga de abrir la ventana de registro al clickar sobre el botón de registro.
         * */
        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        /**
         * Variables de la clase.
         * */
        String userNameInfo;
        String userPasswordInfo;
        XmlDocument userInfoLoad = new XmlDocument();

        /**
         * Método que se encarga de obtener el nombre de usuario que ingresa el cliente al intentar iniciar sesión.
         * */
        private void userName_OnValueChanged(object sender, EventArgs e)
        {
            userNameInfo = userName.Text;
        }

        /**
         * Método que se encarga de obtener el password que ingresa el cliente al intentar iniciar sesión.
         * */
        private void userPassword_OnValueChanged(object sender, EventArgs e)
        {
            userPasswordInfo = userPassword.Text;
        }


        
        /**
         * Método que se encarga de verificar si el usuario se encuentra registrado y posteriormente inicia sesión
         * */
        private void logInButton_Click(object sender, EventArgs e)
        {
            userInfoLoad.Load(@"C:\\Users\jonat\\OneDrive\\Jonathan\\Trabajos TEC\\Computadores\\Algoritmos y Estructura de Datos I\\Eclipse-Workspace\\Odyssey\\ClienteGUI\\UsersInfo.xml");
            XmlNode userNameLoad = userInfoLoad.SelectSingleNode("//Details/UserName/text()");
            XmlNode userPasswordLoad = userInfoLoad.SelectSingleNode("//Details/UserPassword/text()");
            String userPasswordDecrypted = GetOrignalPassword(userPasswordLoad.Value);
            String userPasswordEncrypted = GetOrignalPassword(userPasswordInfo);

            if ((userNameInfo != userNameLoad.Value) || (userPasswordEncrypted != userPasswordLoad.Value))
            {
                MessageBox.Show("Por favor ingrese sus datos correctamente");
                //MessageBox.Show(userPasswordDecrypted);
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
