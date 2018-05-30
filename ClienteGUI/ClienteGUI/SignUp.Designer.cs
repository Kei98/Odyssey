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
            this.userNameInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userEmailInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userPasswordInfo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.pictureBox1.Location = new System.Drawing.Point(109, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.userNameInfo.Location = new System.Drawing.Point(45, 358);
            this.userNameInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userNameInfo.MaxLength = 32767;
            this.userNameInfo.Name = "userNameInfo";
            this.userNameInfo.Size = new System.Drawing.Size(408, 40);
            this.userNameInfo.TabIndex = 2;
            this.userNameInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.userEmailInfo.Location = new System.Drawing.Point(45, 444);
            this.userEmailInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userEmailInfo.MaxLength = 32767;
            this.userEmailInfo.Name = "userEmailInfo";
            this.userEmailInfo.Size = new System.Drawing.Size(408, 40);
            this.userEmailInfo.TabIndex = 3;
            this.userEmailInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.userPasswordInfo.Location = new System.Drawing.Point(45, 529);
            this.userPasswordInfo.Margin = new System.Windows.Forms.Padding(4);
            this.userPasswordInfo.MaxLength = 32767;
            this.userPasswordInfo.Name = "userPasswordInfo";
            this.userPasswordInfo.Size = new System.Drawing.Size(408, 40);
            this.userPasswordInfo.TabIndex = 4;
            this.userPasswordInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 331);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 23);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Full Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 417);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(73, 23);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Email";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(41, 502);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(131, 23);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("LetterOMatic!", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(46, 584);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(270, 23);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Reenter - Password";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = true;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Aqua;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.SpringGreen;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(45, 611);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(408, 40);
            this.bunifuMaterialTextbox1.TabIndex = 11;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SignUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(496, 775);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.userPasswordInfo);
            this.Controls.Add(this.userEmailInfo);
            this.Controls.Add(this.userNameInfo);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userEmailInfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userPasswordInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 signUpButton;
        private Bunifu.Framework.UI.BunifuThinButton2 logInButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}