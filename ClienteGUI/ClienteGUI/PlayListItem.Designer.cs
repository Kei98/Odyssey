namespace ClienteGUI
{
    partial class PlayListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListItem));
            this.actPlayBotton = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeSongLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.songTextName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.artistNameText = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.actPlayBotton)).BeginInit();
            this.SuspendLayout();
            // 
            // actPlayBotton
            // 
            this.actPlayBotton.Image = ((System.Drawing.Image)(resources.GetObject("actPlayBotton.Image")));
            this.actPlayBotton.ImageActive = null;
            this.actPlayBotton.Location = new System.Drawing.Point(25, 15);
            this.actPlayBotton.Name = "actPlayBotton";
            this.actPlayBotton.Size = new System.Drawing.Size(66, 56);
            this.actPlayBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.actPlayBotton.TabIndex = 0;
            this.actPlayBotton.TabStop = false;
            this.actPlayBotton.Zoom = 10;
            this.actPlayBotton.Click += new System.EventHandler(this.actPlayBotton_Click);
            // 
            // timeSongLabel
            // 
            this.timeSongLabel.AutoSize = true;
            this.timeSongLabel.Location = new System.Drawing.Point(567, 34);
            this.timeSongLabel.Name = "timeSongLabel";
            this.timeSongLabel.Size = new System.Drawing.Size(36, 17);
            this.timeSongLabel.TabIndex = 1;
            this.timeSongLabel.Text = "5:00";
            // 
            // songTextName
            // 
            this.songTextName.AutoSize = true;
            this.songTextName.Font = new System.Drawing.Font("Led Italic Font", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.songTextName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.songTextName.Location = new System.Drawing.Point(118, 20);
            this.songTextName.Name = "songTextName";
            this.songTextName.Size = new System.Drawing.Size(167, 38);
            this.songTextName.TabIndex = 2;
            this.songTextName.Text = "Song Name";
            // 
            // artistNameText
            // 
            this.artistNameText.AutoSize = true;
            this.artistNameText.Font = new System.Drawing.Font("Led Italic Font", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.artistNameText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.artistNameText.Location = new System.Drawing.Point(351, 20);
            this.artistNameText.Name = "artistNameText";
            this.artistNameText.Size = new System.Drawing.Size(167, 38);
            this.artistNameText.TabIndex = 3;
            this.artistNameText.Text = "Artist Name";
            // 
            // PlayListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.artistNameText);
            this.Controls.Add(this.songTextName);
            this.Controls.Add(this.timeSongLabel);
            this.Controls.Add(this.actPlayBotton);
            this.Name = "PlayListItem";
            this.Size = new System.Drawing.Size(620, 85);
            this.Load += new System.EventHandler(this.PlayListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actPlayBotton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton actPlayBotton;
        private Bunifu.Framework.UI.BunifuCustomLabel timeSongLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel songTextName;
        private Bunifu.Framework.UI.BunifuCustomLabel artistNameText;
    }
}
