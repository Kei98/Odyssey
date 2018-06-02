using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography;

namespace ClienteGUI
{
    public partial class SignUp : Form
    {
        /**
         * Método que inicializa la clase.
         * */
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        /**
         * Método que se encarga de cerrar la aplicación al clickar sobre el botón de apagado.
         * */
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Método que se encarga de transferir de ventana al usuario.
         * */
        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        /**
         * Método que se encarga de validar que los datos ingresados por el usuario cumplan las normar de la aplicación.
         * */
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

        /**
         * Variables de la clase.
         * */
        String fullName;
        String userName;
        int userAge;
        String userAgeString;
        String userPassword;
        String userPasswordRe;
        String userCryptedPassword;

        /**
         * Método que se encarga de encriptar la clave que ingresa el usuario al registrarse.
         * */
        private String GetMD5(string password)
        {
            MD5CryptoServiceProvider userMD5Password = new MD5CryptoServiceProvider();
            userMD5Password.ComputeHash(ASCIIEncoding.ASCII.GetBytes(userPassword));
            byte[] result = userMD5Password.Hash;
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }

        /**
         * Método que se encarga de obtener el nombre completo que ingresa el cliente al intentar registrarse.
         * */
        private void nameInfo_OnValueChanged(object sender, EventArgs e)
        {
            fullName = nameInfo.Text;
        }

        /**
         * Método que se encarga de obtener el nombre de usuario que ingresa el cliente al intentar registrarse.
         * */
        private void userNameInfo_OnValueChanged(object sender, EventArgs e)
        {
            userName = userNameInfo.Text;
        }

        /**
         * Método que se encarga de obtener la edad que ingresa el cliente al intentar registrarse.
         * */
        private void userEmailInfo_OnValueChanged(object sender, EventArgs e)
        {
            userAge = Int32.Parse(userEmailInfo.Text);
            userAgeString = userEmailInfo.Text;
        }

        /**
         * Método que se encarga de obtener el password que ingresa el cliente al intentar registrarse.
         * */
        private void userPasswordInfo_OnValueChanged(object sender, EventArgs e)
        {
            userPassword = userPasswordInfo.Text;
            userCryptedPassword = GetMD5(userPassword);
        }

        /**
         * Método que se encarga de obtener el password que ingresa el cliente al intentar registrarse.
         * */
        private void userPasswordInfoEvaluation_OnValueChanged(object sender, EventArgs e)
        {
            userPasswordRe = userPasswordInfoEvaluation.Text;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        /**
         * Método que se encarga de validar el registro de la cuenta, además de guardar los datos de registro en un XMl 
         * que posteriormente será enviado al server. Si el registro se completa correctamente el usuario el redirigido
         * a la ventana de Log In para que proceda a iniciar sesión.
         * */
        private void signUpButton_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                MessageBox.Show("Reingrese sus datos de nuevo");
            }
            else
            {
                XmlDocument usersInfo = new XmlDocument();

                XmlDeclaration xmlDeclaration = usersInfo.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = usersInfo.DocumentElement;
                usersInfo.InsertBefore(xmlDeclaration, root);

                XmlElement element1 = usersInfo.CreateElement(string.Empty, "UserInfo", string.Empty);
                usersInfo.AppendChild(element1);

                XmlElement element2 = usersInfo.CreateElement(string.Empty, "Details", string.Empty);
                element1.AppendChild(element2);

                XmlElement element3 = usersInfo.CreateElement(string.Empty, "UserFullName", string.Empty);
                XmlText text1 = usersInfo.CreateTextNode(fullName);
                element3.AppendChild(text1);
                element2.AppendChild(element3);

                XmlElement element4 = usersInfo.CreateElement(string.Empty, "UserName", string.Empty);
                XmlText text2 = usersInfo.CreateTextNode(userName);
                element4.AppendChild(text2);
                element2.AppendChild(element4);
               
                XmlElement element5 = usersInfo.CreateElement(string.Empty, "UserAge", string.Empty);
                XmlText text3 = usersInfo.CreateTextNode(userAgeString);
                element5.AppendChild(text3);
                element2.AppendChild(element5);
                
                XmlElement element6 = usersInfo.CreateElement(string.Empty, "UserPassword", string.Empty);
                XmlText text4 = usersInfo.CreateTextNode(userCryptedPassword);
                element6.AppendChild(text4);
                element2.AppendChild(element6);

                usersInfo.Save("C:\\Users\\jonat\\OneDrive\\Jonathan\\Trabajos TEC\\Computadores\\Algoritmos y Estructura de Datos I\\Eclipse-Workspace\\Odyssey\\ClienteGUI\\UsersInfo.xml");

                this.Hide();
                LogIn logIn = new LogIn();

                logIn.Show();
            }
        }
    }
}