﻿using System;
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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUp signUp = new SignUp();

            signUp.Show();
        }

        private void userName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reproducer reproducer = new Reproducer();

            reproducer.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
