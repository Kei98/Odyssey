namespace ClienteGUI
{
    partial class Reproducer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproducer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.musicNavigationPanel = new System.Windows.Forms.Panel();
            this.artistsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.songsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.yourLibraryButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.yourMusic = new System.Windows.Forms.Label();
            this.mainMusic = new System.Windows.Forms.Label();
            this.searchTextButton = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.musicImagePanel = new System.Windows.Forms.Panel();
            this.albumBotton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.friendsBotton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.artistButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.songButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicPlayPanel = new System.Windows.Forms.Panel();
            this.prevBotton = new Bunifu.Framework.UI.BunifuImageButton();
            this.nextBotton = new Bunifu.Framework.UI.BunifuImageButton();
            this.playBotton = new Bunifu.Framework.UI.BunifuImageButton();
            this.soundLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.totalTimeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.begginingTimeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.soundSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.reproducerSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.musicAlocatedPanel = new System.Windows.Forms.Panel();
            this.playListItem4 = new ClienteGUI.PlayListItem();
            this.playListItem3 = new ClienteGUI.PlayListItem();
            this.playListItem2 = new ClienteGUI.PlayListItem();
            this.playListItem1 = new ClienteGUI.PlayListItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.musicNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.musicImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.musicPlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBotton)).BeginInit();
            this.musicAlocatedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // musicNavigationPanel
            // 
            this.musicNavigationPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.musicNavigationPanel.Controls.Add(this.artistsButton);
            this.musicNavigationPanel.Controls.Add(this.songsButton);
            this.musicNavigationPanel.Controls.Add(this.yourLibraryButton);
            this.musicNavigationPanel.Controls.Add(this.yourMusic);
            this.musicNavigationPanel.Controls.Add(this.mainMusic);
            this.musicNavigationPanel.Controls.Add(this.searchTextButton);
            this.musicNavigationPanel.Controls.Add(this.bunifuImageButton1);
            this.musicNavigationPanel.Controls.Add(this.searchButton);
            this.musicNavigationPanel.Controls.Add(this.pictureBox2);
            this.musicNavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.musicNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.musicNavigationPanel.Name = "musicNavigationPanel";
            this.musicNavigationPanel.Size = new System.Drawing.Size(226, 694);
            this.musicNavigationPanel.TabIndex = 0;
            // 
            // artistsButton
            // 
            this.artistsButton.Active = false;
            this.artistsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.artistsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.artistsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artistsButton.BorderRadius = 0;
            this.artistsButton.ButtonText = "Artist";
            this.artistsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artistsButton.DisabledColor = System.Drawing.Color.Gray;
            this.artistsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.artistsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("artistsButton.Iconimage")));
            this.artistsButton.Iconimage_right = null;
            this.artistsButton.Iconimage_right_Selected = null;
            this.artistsButton.Iconimage_Selected = null;
            this.artistsButton.IconMarginLeft = 10;
            this.artistsButton.IconMarginRight = 0;
            this.artistsButton.IconRightVisible = true;
            this.artistsButton.IconRightZoom = 0D;
            this.artistsButton.IconVisible = true;
            this.artistsButton.IconZoom = 50D;
            this.artistsButton.IsTab = false;
            this.artistsButton.Location = new System.Drawing.Point(12, 415);
            this.artistsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artistsButton.Name = "artistsButton";
            this.artistsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.artistsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.artistsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.artistsButton.selected = false;
            this.artistsButton.Size = new System.Drawing.Size(200, 27);
            this.artistsButton.TabIndex = 10;
            this.artistsButton.Text = "Artist";
            this.artistsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.artistsButton.Textcolor = System.Drawing.Color.White;
            this.artistsButton.TextFont = new System.Drawing.Font("Neon Lights", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // songsButton
            // 
            this.songsButton.Active = false;
            this.songsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.songsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.songsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.songsButton.BorderRadius = 0;
            this.songsButton.ButtonText = "Song";
            this.songsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songsButton.DisabledColor = System.Drawing.Color.Gray;
            this.songsButton.Font = new System.Drawing.Font("Neon Lights", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.songsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("songsButton.Iconimage")));
            this.songsButton.Iconimage_right = null;
            this.songsButton.Iconimage_right_Selected = null;
            this.songsButton.Iconimage_Selected = null;
            this.songsButton.IconMarginLeft = 10;
            this.songsButton.IconMarginRight = 0;
            this.songsButton.IconRightVisible = true;
            this.songsButton.IconRightZoom = 0D;
            this.songsButton.IconVisible = true;
            this.songsButton.IconZoom = 50D;
            this.songsButton.IsTab = false;
            this.songsButton.Location = new System.Drawing.Point(12, 374);
            this.songsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.songsButton.Name = "songsButton";
            this.songsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.songsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.songsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.songsButton.selected = false;
            this.songsButton.Size = new System.Drawing.Size(200, 32);
            this.songsButton.TabIndex = 9;
            this.songsButton.Text = "Song";
            this.songsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songsButton.Textcolor = System.Drawing.Color.White;
            this.songsButton.TextFont = new System.Drawing.Font("Neon Lights", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // yourLibraryButton
            // 
            this.yourLibraryButton.Active = false;
            this.yourLibraryButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yourLibraryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yourLibraryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourLibraryButton.BorderRadius = 0;
            this.yourLibraryButton.ButtonText = "Your Library";
            this.yourLibraryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yourLibraryButton.DisabledColor = System.Drawing.Color.Gray;
            this.yourLibraryButton.Iconcolor = System.Drawing.Color.Transparent;
            this.yourLibraryButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("yourLibraryButton.Iconimage")));
            this.yourLibraryButton.Iconimage_right = null;
            this.yourLibraryButton.Iconimage_right_Selected = null;
            this.yourLibraryButton.Iconimage_Selected = null;
            this.yourLibraryButton.IconMarginLeft = 10;
            this.yourLibraryButton.IconMarginRight = 0;
            this.yourLibraryButton.IconRightVisible = true;
            this.yourLibraryButton.IconRightZoom = 0D;
            this.yourLibraryButton.IconVisible = true;
            this.yourLibraryButton.IconZoom = 50D;
            this.yourLibraryButton.IsTab = false;
            this.yourLibraryButton.Location = new System.Drawing.Point(13, 450);
            this.yourLibraryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yourLibraryButton.Name = "yourLibraryButton";
            this.yourLibraryButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.yourLibraryButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.yourLibraryButton.OnHoverTextColor = System.Drawing.Color.White;
            this.yourLibraryButton.selected = false;
            this.yourLibraryButton.Size = new System.Drawing.Size(200, 27);
            this.yourLibraryButton.TabIndex = 8;
            this.yourLibraryButton.Text = "Your Library";
            this.yourLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yourLibraryButton.Textcolor = System.Drawing.Color.White;
            this.yourLibraryButton.TextFont = new System.Drawing.Font("Neon Lights", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourLibraryButton.Click += new System.EventHandler(this.yourLibraryButton_Click);
            // 
            // yourMusic
            // 
            this.yourMusic.AutoSize = true;
            this.yourMusic.Font = new System.Drawing.Font("Neon Lights", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourMusic.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.yourMusic.Location = new System.Drawing.Point(12, 317);
            this.yourMusic.Name = "yourMusic";
            this.yourMusic.Size = new System.Drawing.Size(126, 25);
            this.yourMusic.TabIndex = 5;
            this.yourMusic.Text = "Your Music";
            // 
            // mainMusic
            // 
            this.mainMusic.AutoSize = true;
            this.mainMusic.Font = new System.Drawing.Font("Neon Lights", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMusic.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.mainMusic.Location = new System.Drawing.Point(12, 161);
            this.mainMusic.Name = "mainMusic";
            this.mainMusic.Size = new System.Drawing.Size(60, 25);
            this.mainMusic.TabIndex = 4;
            this.mainMusic.Text = "Main";
            // 
            // searchTextButton
            // 
            this.searchTextButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchTextButton.BorderColor = System.Drawing.Color.SeaGreen;
            this.searchTextButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchTextButton.Location = new System.Drawing.Point(12, 71);
            this.searchTextButton.Name = "searchTextButton";
            this.searchTextButton.Size = new System.Drawing.Size(149, 22);
            this.searchTextButton.TabIndex = 3;
            this.searchTextButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 36);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = null;
            this.searchButton.Location = new System.Drawing.Point(167, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 50);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 1;
            this.searchButton.TabStop = false;
            this.searchButton.Zoom = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 540);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // musicImagePanel
            // 
            this.musicImagePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.musicImagePanel.Controls.Add(this.albumBotton);
            this.musicImagePanel.Controls.Add(this.friendsBotton);
            this.musicImagePanel.Controls.Add(this.artistButton);
            this.musicImagePanel.Controls.Add(this.songButton);
            this.musicImagePanel.Controls.Add(this.pictureBox1);
            this.musicImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicImagePanel.Location = new System.Drawing.Point(226, 0);
            this.musicImagePanel.Name = "musicImagePanel";
            this.musicImagePanel.Size = new System.Drawing.Size(927, 186);
            this.musicImagePanel.TabIndex = 1;
            // 
            // albumBotton
            // 
            this.albumBotton.ActiveBorderThickness = 1;
            this.albumBotton.ActiveCornerRadius = 25;
            this.albumBotton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.albumBotton.ActiveForecolor = System.Drawing.Color.DarkGreen;
            this.albumBotton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.albumBotton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.albumBotton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("albumBotton.BackgroundImage")));
            this.albumBotton.ButtonText = "Album";
            this.albumBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumBotton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumBotton.ForeColor = System.Drawing.Color.SeaGreen;
            this.albumBotton.IdleBorderThickness = 1;
            this.albumBotton.IdleCornerRadius = 20;
            this.albumBotton.IdleFillColor = System.Drawing.Color.White;
            this.albumBotton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.albumBotton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.albumBotton.Location = new System.Drawing.Point(550, 137);
            this.albumBotton.Margin = new System.Windows.Forms.Padding(5);
            this.albumBotton.Name = "albumBotton";
            this.albumBotton.Size = new System.Drawing.Size(181, 41);
            this.albumBotton.TabIndex = 4;
            this.albumBotton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendsBotton
            // 
            this.friendsBotton.ActiveBorderThickness = 1;
            this.friendsBotton.ActiveCornerRadius = 25;
            this.friendsBotton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.friendsBotton.ActiveForecolor = System.Drawing.Color.DarkGreen;
            this.friendsBotton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.friendsBotton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.friendsBotton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friendsBotton.BackgroundImage")));
            this.friendsBotton.ButtonText = "Friends";
            this.friendsBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsBotton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsBotton.ForeColor = System.Drawing.Color.SeaGreen;
            this.friendsBotton.IdleBorderThickness = 1;
            this.friendsBotton.IdleCornerRadius = 20;
            this.friendsBotton.IdleFillColor = System.Drawing.Color.White;
            this.friendsBotton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.friendsBotton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.friendsBotton.Location = new System.Drawing.Point(741, 137);
            this.friendsBotton.Margin = new System.Windows.Forms.Padding(5);
            this.friendsBotton.Name = "friendsBotton";
            this.friendsBotton.Size = new System.Drawing.Size(181, 41);
            this.friendsBotton.TabIndex = 3;
            this.friendsBotton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artistButton
            // 
            this.artistButton.ActiveBorderThickness = 1;
            this.artistButton.ActiveCornerRadius = 25;
            this.artistButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.artistButton.ActiveForecolor = System.Drawing.Color.DarkGreen;
            this.artistButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.artistButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.artistButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("artistButton.BackgroundImage")));
            this.artistButton.ButtonText = "Artist";
            this.artistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.artistButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.artistButton.IdleBorderThickness = 1;
            this.artistButton.IdleCornerRadius = 20;
            this.artistButton.IdleFillColor = System.Drawing.Color.White;
            this.artistButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.artistButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.artistButton.Location = new System.Drawing.Point(199, 137);
            this.artistButton.Margin = new System.Windows.Forms.Padding(5);
            this.artistButton.Name = "artistButton";
            this.artistButton.Size = new System.Drawing.Size(181, 41);
            this.artistButton.TabIndex = 2;
            this.artistButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // songButton
            // 
            this.songButton.ActiveBorderThickness = 1;
            this.songButton.ActiveCornerRadius = 25;
            this.songButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.songButton.ActiveForecolor = System.Drawing.Color.DarkGreen;
            this.songButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.songButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.songButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songButton.BackgroundImage")));
            this.songButton.ButtonText = "Song";
            this.songButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.songButton.IdleBorderThickness = 1;
            this.songButton.IdleCornerRadius = 20;
            this.songButton.IdleFillColor = System.Drawing.Color.White;
            this.songButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.songButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.songButton.Location = new System.Drawing.Point(8, 137);
            this.songButton.Margin = new System.Windows.Forms.Padding(5);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(181, 41);
            this.songButton.TabIndex = 1;
            this.songButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // musicPlayPanel
            // 
            this.musicPlayPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.musicPlayPanel.Controls.Add(this.prevBotton);
            this.musicPlayPanel.Controls.Add(this.nextBotton);
            this.musicPlayPanel.Controls.Add(this.playBotton);
            this.musicPlayPanel.Controls.Add(this.soundLabel);
            this.musicPlayPanel.Controls.Add(this.totalTimeLabel);
            this.musicPlayPanel.Controls.Add(this.begginingTimeLabel);
            this.musicPlayPanel.Controls.Add(this.soundSlider);
            this.musicPlayPanel.Controls.Add(this.reproducerSlider);
            this.musicPlayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicPlayPanel.Location = new System.Drawing.Point(226, 598);
            this.musicPlayPanel.Name = "musicPlayPanel";
            this.musicPlayPanel.Size = new System.Drawing.Size(927, 96);
            this.musicPlayPanel.TabIndex = 2;
            // 
            // prevBotton
            // 
            this.prevBotton.Image = ((System.Drawing.Image)(resources.GetObject("prevBotton.Image")));
            this.prevBotton.ImageActive = null;
            this.prevBotton.Location = new System.Drawing.Point(401, 17);
            this.prevBotton.Name = "prevBotton";
            this.prevBotton.Size = new System.Drawing.Size(46, 44);
            this.prevBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prevBotton.TabIndex = 6;
            this.prevBotton.TabStop = false;
            this.prevBotton.Zoom = 10;
            // 
            // nextBotton
            // 
            this.nextBotton.Image = ((System.Drawing.Image)(resources.GetObject("nextBotton.Image")));
            this.nextBotton.ImageActive = null;
            this.nextBotton.Location = new System.Drawing.Point(517, 17);
            this.nextBotton.Name = "nextBotton";
            this.nextBotton.Size = new System.Drawing.Size(46, 44);
            this.nextBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBotton.TabIndex = 5;
            this.nextBotton.TabStop = false;
            this.nextBotton.Zoom = 10;
            // 
            // playBotton
            // 
            this.playBotton.Image = ((System.Drawing.Image)(resources.GetObject("playBotton.Image")));
            this.playBotton.ImageActive = null;
            this.playBotton.Location = new System.Drawing.Point(453, 17);
            this.playBotton.Name = "playBotton";
            this.playBotton.Size = new System.Drawing.Size(46, 44);
            this.playBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playBotton.TabIndex = 4;
            this.playBotton.TabStop = false;
            this.playBotton.Zoom = 10;
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Location = new System.Drawing.Point(886, 67);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(36, 17);
            this.soundLabel.TabIndex = 3;
            this.soundLabel.Text = "0:00";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(738, 67);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(36, 17);
            this.totalTimeLabel.TabIndex = 3;
            this.totalTimeLabel.Text = "0:00";
            // 
            // begginingTimeLabel
            // 
            this.begginingTimeLabel.AutoSize = true;
            this.begginingTimeLabel.Location = new System.Drawing.Point(153, 67);
            this.begginingTimeLabel.Name = "begginingTimeLabel";
            this.begginingTimeLabel.Size = new System.Drawing.Size(36, 17);
            this.begginingTimeLabel.TabIndex = 2;
            this.begginingTimeLabel.Text = "0:00";
            // 
            // soundSlider
            // 
            this.soundSlider.BackColor = System.Drawing.Color.Transparent;
            this.soundSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.soundSlider.BorderRadius = 5;
            this.soundSlider.IndicatorColor = System.Drawing.Color.MediumTurquoise;
            this.soundSlider.Location = new System.Drawing.Point(781, 57);
            this.soundSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soundSlider.MaximumValue = 100;
            this.soundSlider.Name = "soundSlider";
            this.soundSlider.Size = new System.Drawing.Size(91, 35);
            this.soundSlider.TabIndex = 1;
            this.soundSlider.Value = 0;
            // 
            // reproducerSlider
            // 
            this.reproducerSlider.BackColor = System.Drawing.Color.Transparent;
            this.reproducerSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.reproducerSlider.BorderRadius = 5;
            this.reproducerSlider.IndicatorColor = System.Drawing.Color.MediumTurquoise;
            this.reproducerSlider.Location = new System.Drawing.Point(196, 57);
            this.reproducerSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reproducerSlider.MaximumValue = 100;
            this.reproducerSlider.Name = "reproducerSlider";
            this.reproducerSlider.Size = new System.Drawing.Size(532, 35);
            this.reproducerSlider.TabIndex = 0;
            this.reproducerSlider.Value = 0;
            // 
            // musicAlocatedPanel
            // 
            this.musicAlocatedPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.musicAlocatedPanel.Controls.Add(this.playListItem4);
            this.musicAlocatedPanel.Controls.Add(this.playListItem3);
            this.musicAlocatedPanel.Controls.Add(this.playListItem2);
            this.musicAlocatedPanel.Controls.Add(this.playListItem1);
            this.musicAlocatedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicAlocatedPanel.Location = new System.Drawing.Point(226, 186);
            this.musicAlocatedPanel.Name = "musicAlocatedPanel";
            this.musicAlocatedPanel.Size = new System.Drawing.Size(927, 412);
            this.musicAlocatedPanel.TabIndex = 3;
            // 
            // playListItem4
            // 
            this.playListItem4.Artist = "Artist Name";
            this.playListItem4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playListItem4.Duration = "5:00";
            this.playListItem4.isPlaying = false;
            this.playListItem4.Location = new System.Drawing.Point(21, 291);
            this.playListItem4.Name = "playListItem4";
            this.playListItem4.Size = new System.Drawing.Size(620, 85);
            this.playListItem4.Song = "Song Name";
            this.playListItem4.TabIndex = 3;
            this.playListItem4.Tag = "none";
            this.playListItem4.onAction += new System.EventHandler(this.playListItem1_Load);
            // 
            // playListItem3
            // 
            this.playListItem3.Artist = "Artist Name";
            this.playListItem3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playListItem3.Duration = "5:00";
            this.playListItem3.isPlaying = false;
            this.playListItem3.Location = new System.Drawing.Point(21, 200);
            this.playListItem3.Name = "playListItem3";
            this.playListItem3.Size = new System.Drawing.Size(620, 85);
            this.playListItem3.Song = "Song Name";
            this.playListItem3.TabIndex = 2;
            this.playListItem3.Tag = "none";
            this.playListItem3.onAction += new System.EventHandler(this.playListItem1_Load);
            // 
            // playListItem2
            // 
            this.playListItem2.Artist = "Artist Name";
            this.playListItem2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playListItem2.Duration = "5:00";
            this.playListItem2.isPlaying = false;
            this.playListItem2.Location = new System.Drawing.Point(21, 109);
            this.playListItem2.Name = "playListItem2";
            this.playListItem2.Size = new System.Drawing.Size(620, 85);
            this.playListItem2.Song = "Song Name";
            this.playListItem2.TabIndex = 1;
            this.playListItem2.Tag = "none";
            this.playListItem2.onAction += new System.EventHandler(this.playListItem1_Load);
            // 
            // playListItem1
            // 
            this.playListItem1.Artist = "Artist Name";
            this.playListItem1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.playListItem1.Duration = "5:00";
            this.playListItem1.isPlaying = false;
            this.playListItem1.Location = new System.Drawing.Point(21, 18);
            this.playListItem1.Name = "playListItem1";
            this.playListItem1.Size = new System.Drawing.Size(620, 85);
            this.playListItem1.Song = "Song Name";
            this.playListItem1.TabIndex = 0;
            this.playListItem1.Tag = "none";
            this.playListItem1.onAction += new System.EventHandler(this.playListItem1_Load);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Reproducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 694);
            this.Controls.Add(this.musicAlocatedPanel);
            this.Controls.Add(this.musicPlayPanel);
            this.Controls.Add(this.musicImagePanel);
            this.Controls.Add(this.musicNavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reproducer";
            this.Text = "Reproducer";
            this.musicNavigationPanel.ResumeLayout(false);
            this.musicNavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.musicImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.musicPlayPanel.ResumeLayout(false);
            this.musicPlayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBotton)).EndInit();
            this.musicAlocatedPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel musicAlocatedPanel;
        private System.Windows.Forms.Panel musicPlayPanel;
        private System.Windows.Forms.Panel musicImagePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel musicNavigationPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton searchButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 songButton;
        private Bunifu.Framework.UI.BunifuThinButton2 albumBotton;
        private Bunifu.Framework.UI.BunifuThinButton2 friendsBotton;
        private Bunifu.Framework.UI.BunifuThinButton2 artistButton;
        private Bunifu.Framework.BunifuCustomTextbox searchTextButton;
        private System.Windows.Forms.Label yourMusic;
        private System.Windows.Forms.Label mainMusic;
        private Bunifu.Framework.UI.BunifuFlatButton artistsButton;
        private Bunifu.Framework.UI.BunifuFlatButton songsButton;
        private Bunifu.Framework.UI.BunifuFlatButton yourLibraryButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuSlider reproducerSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel soundLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel totalTimeLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel begginingTimeLabel;
        private Bunifu.Framework.UI.BunifuSlider soundSlider;
        private Bunifu.Framework.UI.BunifuImageButton prevBotton;
        private Bunifu.Framework.UI.BunifuImageButton nextBotton;
        private Bunifu.Framework.UI.BunifuImageButton playBotton;
        private PlayListItem playListItem4;
        private PlayListItem playListItem3;
        private PlayListItem playListItem2;
        private PlayListItem playListItem1;
    }
}