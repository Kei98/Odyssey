namespace ClienteGUI
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userEmailInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userPasswordInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ageUserInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userPasswordInfoEvaluation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.userNameInfoUser = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userNameInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(413, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nameInfo
            // 
            this.nameInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameInfo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameInfo.ForeColor = System.Drawing.Color.White;
            this.nameInfo.HintForeColor = System.Drawing.Color.White;
            this.nameInfo.HintText = "";
            this.nameInfo.isPassword = false;
            this.nameInfo.LineFocusedColor = System.Drawing.Color.Aqua;
            this.nameInfo.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.nameInfo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.nameInfo.LineThickness = 3;
            this.nameInfo.Location = new System.Drawing.Point(45, 263);
            this.nameInfo.Margin = new System.Windows.Forms.Padding(4);
            this.nameInfo.MaxLength = 32767;
            this.nameInfo.Name = "nameInfo";
            this.nameInfo.Size = new System.Drawing.Size(408, 40);
            this.nameInfo.TabIndex = 2;
            this.nameInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameInfo.OnValueChanged += new System.EventHandler(this.nameInfo_OnValueChanged);
            // 
            // userEmailInfo
            // 
            this.userEmailInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userEmailInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userEmailInfo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userEmailInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userEmailInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userEmailInfo.ForeColor = System.Drawing.Color.White;
            this.userEmailInfo.HintForeColor = System.Drawing.Color.White;
            this.userEmailInfo.HintText = "";
            this.userEmailInfo.isPassword = false;
            this.userEmailInfo.LineFocusedColor = System.Drawing.Color.Aqua;
            this.userEmailInfo.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userEmailInfo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.userEmailInfo.LineThickness = 3;
            this.userEmailInfo.Location = new System.Drawing.Point(45, 334);
            this.userEmailInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userEmailInfo.MaxLength = 32767;
            this.userEmailInfo.Name = "userEmailInfo";
            this.userEmailInfo.Size = new System.Drawing.Size(408, 40);
            this.userEmailInfo.TabIndex = 3;
            this.userEmailInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userEmailInfo.OnValueChanged += new System.EventHandler(this.userEmailInfo_OnValueChanged);
            // 
            // userPasswordInfo
            // 
            this.userPasswordInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userPasswordInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userPasswordInfo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPasswordInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPasswordInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userPasswordInfo.ForeColor = System.Drawing.Color.White;
            this.userPasswordInfo.HintForeColor = System.Drawing.Color.White;
            this.userPasswordInfo.HintText = "";
            this.userPasswordInfo.isPassword = true;
            this.userPasswordInfo.LineFocusedColor = System.Drawing.Color.Aqua;
            this.userPasswordInfo.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userPasswordInfo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.userPasswordInfo.LineThickness = 3;
            this.userPasswordInfo.Location = new System.Drawing.Point(46, 405);
            this.userPasswordInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userPasswordInfo.MaxLength = 32767;
            this.userPasswordInfo.Name = "userPasswordInfo";
            this.userPasswordInfo.Size = new System.Drawing.Size(408, 40);
            this.userPasswordInfo.TabIndex = 4;
            this.userPasswordInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userPasswordInfo.OnValueChanged += new System.EventHandler(this.userPasswordInfo_OnValueChanged);
            // 
            // signUpButton
            // 
            this.signUpButton.ActiveBorderThickness = 1;
            this.signUpButton.ActiveCornerRadius = 25;
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
            this.signUpButton.IdleCornerRadius = 20;
            this.signUpButton.IdleFillColor = System.Drawing.Color.White;
            this.signUpButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.signUpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signUpButton.Location = new System.Drawing.Point(158, 656);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(181, 41);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.ActiveBorderThickness = 1;
            this.logInButton.ActiveCornerRadius = 25;
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
            this.logInButton.IdleCornerRadius = 20;
            this.logInButton.IdleFillColor = System.Drawing.Color.White;
            this.logInButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.logInButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.logInButton.Location = new System.Drawing.Point(158, 720);
            this.logInButton.Margin = new System.Windows.Forms.Padding(5);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(181, 41);
            this.logInButton.TabIndex = 6;
            this.logInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 236);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 23);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Full Name";
            // 
            // ageUserInfo
            // 
            this.ageUserInfo.AutoSize = true;
            this.ageUserInfo.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageUserInfo.Location = new System.Drawing.Point(42, 307);
            this.ageUserInfo.Name = "ageUserInfo";
            this.ageUserInfo.Size = new System.Drawing.Size(54, 23);
            this.ageUserInfo.TabIndex = 8;
            this.ageUserInfo.Text = "Age";
            this.ageUserInfo.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 378);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(131, 23);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(42, 449);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(270, 23);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Reenter - Password";
            // 
            // userPasswordInfoEvaluation
            // 
            this.userPasswordInfoEvaluation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userPasswordInfoEvaluation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userPasswordInfoEvaluation.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPasswordInfoEvaluation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPasswordInfoEvaluation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userPasswordInfoEvaluation.ForeColor = System.Drawing.Color.White;
            this.userPasswordInfoEvaluation.HintForeColor = System.Drawing.Color.White;
            this.userPasswordInfoEvaluation.HintText = "";
            this.userPasswordInfoEvaluation.isPassword = true;
            this.userPasswordInfoEvaluation.LineFocusedColor = System.Drawing.Color.Aqua;
            this.userPasswordInfoEvaluation.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userPasswordInfoEvaluation.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.userPasswordInfoEvaluation.LineThickness = 3;
            this.userPasswordInfoEvaluation.Location = new System.Drawing.Point(46, 476);
            this.userPasswordInfoEvaluation.Margin = new System.Windows.Forms.Padding(4);
            this.userPasswordInfoEvaluation.MaxLength = 32767;
            this.userPasswordInfoEvaluation.Name = "userPasswordInfoEvaluation";
            this.userPasswordInfoEvaluation.Size = new System.Drawing.Size(408, 40);
            this.userPasswordInfoEvaluation.TabIndex = 11;
            this.userPasswordInfoEvaluation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userPasswordInfoEvaluation.OnValueChanged += new System.EventHandler(this.userPasswordInfoEvaluation_OnValueChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // userNameInfoUser
            // 
            this.userNameInfoUser.AutoSize = true;
            this.userNameInfoUser.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInfoUser.Location = new System.Drawing.Point(42, 520);
            this.userNameInfoUser.Name = "userNameInfoUser";
            this.userNameInfoUser.Size = new System.Drawing.Size(142, 23);
            this.userNameInfoUser.TabIndex = 12;
            this.userNameInfoUser.Text = "User Name";
            // 
            // userNameInfo
            // 
            this.userNameInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameInfo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNameInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userNameInfo.ForeColor = System.Drawing.Color.White;
            this.userNameInfo.HintForeColor = System.Drawing.Color.White;
            this.userNameInfo.HintText = "";
            this.userNameInfo.isPassword = false;
            this.userNameInfo.LineFocusedColor = System.Drawing.Color.Aqua;
            this.userNameInfo.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.userNameInfo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.userNameInfo.LineThickness = 3;
            this.userNameInfo.Location = new System.Drawing.Point(46, 547);
            this.userNameInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userNameInfo.MaxLength = 32767;
            this.userNameInfo.Name = "userNameInfo";
            this.userNameInfo.Size = new System.Drawing.Size(408, 40);
            this.userNameInfo.TabIndex = 13;
            this.userNameInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameInfo.OnValueChanged += new System.EventHandler(this.userNameInfo_OnValueChanged);
            // 
            // SignUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(496, 775);
            this.Controls.Add(this.userNameInfo);
            this.Controls.Add(this.userNameInfoUser);
            this.Controls.Add(this.userPasswordInfoEvaluation);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.ageUserInfo);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.userPasswordInfo);
            this.Controls.Add(this.userEmailInfo);
            this.Controls.Add(this.nameInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userEmailInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userPasswordInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpButton;
        private Bunifu.Framework.UI.BunifuThinButton2 logInButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel ageUserInfo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userPasswordInfoEvaluation;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameInfo;
        private Bunifu.Framework.UI.BunifuCustomLabel userNameInfoUser;
    }
}