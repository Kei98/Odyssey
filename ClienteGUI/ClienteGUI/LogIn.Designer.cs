namespace ClienteGUI
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userNameHint = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userPasswordHint = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(417, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(71, 71);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.HintForeColor = System.Drawing.Color.White;
            this.userName.HintText = "";
            this.userName.isPassword = false;
            this.userName.LineFocusedColor = System.Drawing.Color.Blue;
            this.userName.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userName.LineThickness = 3;
            this.userName.Location = new System.Drawing.Point(136, 472);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.MaxLength = 32767;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(300, 33);
            this.userName.TabIndex = 2;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName.OnValueChanged += new System.EventHandler(this.userName_OnValueChanged);
            // 
            // userPassword
            // 
            this.userPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userPassword.ForeColor = System.Drawing.Color.White;
            this.userPassword.HintForeColor = System.Drawing.Color.White;
            this.userPassword.HintText = "";
            this.userPassword.isPassword = true;
            this.userPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.userPassword.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userPassword.LineThickness = 3;
            this.userPassword.Location = new System.Drawing.Point(136, 567);
            this.userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword.MaxLength = 32767;
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(300, 33);
            this.userPassword.TabIndex = 3;
            this.userPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userPassword.OnValueChanged += new System.EventHandler(this.userPassword_OnValueChanged);
            // 
            // userNameHint
            // 
            this.userNameHint.AutoSize = true;
            this.userNameHint.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameHint.Location = new System.Drawing.Point(132, 443);
            this.userNameHint.Name = "userNameHint";
            this.userNameHint.Size = new System.Drawing.Size(142, 23);
            this.userNameHint.TabIndex = 4;
            this.userNameHint.Text = "User name";
            // 
            // userPasswordHint
            // 
            this.userPasswordHint.AutoSize = true;
            this.userPasswordHint.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordHint.Location = new System.Drawing.Point(132, 525);
            this.userPasswordHint.Name = "userPasswordHint";
            this.userPasswordHint.Size = new System.Drawing.Size(131, 23);
            this.userPasswordHint.TabIndex = 5;
            this.userPasswordHint.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.ActiveBorderThickness = 1;
            this.logInButton.ActiveCornerRadius = 20;
            this.logInButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.logInButton.ActiveForecolor = System.Drawing.Color.White;
            this.logInButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.logInButton.BackColor = System.Drawing.Color.Teal;
            this.logInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logInButton.BackgroundImage")));
            this.logInButton.ButtonText = "Log In";
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.logInButton.IdleBorderThickness = 1;
            this.logInButton.IdleCornerRadius = 25;
            this.logInButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.logInButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.logInButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.logInButton.Location = new System.Drawing.Point(136, 636);
            this.logInButton.Margin = new System.Windows.Forms.Padding(5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(192, 41);
            this.logInButton.TabIndex = 6;
            this.logInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.ActiveBorderThickness = 1;
            this.signUpButton.ActiveCornerRadius = 20;
            this.signUpButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.ActiveForecolor = System.Drawing.Color.White;
            this.signUpButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.BackColor = System.Drawing.Color.Teal;
            this.signUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpButton.BackgroundImage")));
            this.signUpButton.ButtonText = "Sign Up";
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.IdleBorderThickness = 1;
            this.signUpButton.IdleCornerRadius = 25;
            this.signUpButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.signUpButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.Location = new System.Drawing.Point(136, 703);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(192, 41);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(57, 538);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // LogIn
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(502, 776);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.userPasswordHint);
            this.Controls.Add(this.userNameHint);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel userNameHint;
        private Bunifu.Framework.UI.BunifuCustomLabel userPasswordHint;
        private Bunifu.Framework.UI.BunifuThinButton2 logInButton;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}