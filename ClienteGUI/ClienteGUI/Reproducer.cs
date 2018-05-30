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
    public partial class Reproducer : Form
    {
        public Reproducer()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playListItem1_Load(object sender, EventArgs e)
        {
            playListItem1.isPlaying = false;
            playListItem2.isPlaying = false;
            playListItem3.isPlaying = false;
            playListItem4.isPlaying = false;

            ((PlayListItem)sender).isPlaying = true;
            string song = (string)(((PlayListItem)sender).Tag);
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        String fileName;
        String fileLocation;

        private void yourLibraryButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "*.mp3|*.mp3";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                fileLocation = openFileDialog.SafeFileName;

            }
        }

        private void songButton_Click(object sender, EventArgs e)
        {

        }
    }
}
