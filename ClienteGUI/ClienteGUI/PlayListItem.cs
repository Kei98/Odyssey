using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteGUI
{
    public partial class PlayListItem : UserControl
    {
        public PlayListItem()
        {
            InitializeComponent();
        }

        bool _playing = false;

        public bool isPlaying
        {
            get
            {
                return _playing;
            }
            set
            {
                _playing = value;

               // if(_playing)
                //{
                    //actPlayBotton.Image = playing.Image;
                //}
                //actPlayBotton.Image = paused.Image;
            }
        }


        private void PlayListItem_Load(object sender, EventArgs e)
        {

        }

        public String Song
        {
            get {
                return songTextName.Text;
            }
            set
            {
                songTextName.Text = value;
            }
        }

        public String Artist
        {
            get
            {
                return artistNameText.Text;
            }
            set
            {
                artistNameText.Text = value;
            }
        }

        public String Duration
        {
            get
            {
                return timeSongLabel.Text;
            }
            set
            {
                timeSongLabel.Text = value;
            }
        }

        public event EventHandler onAction = null;


        private void actPlayBotton_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;

            if(onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }
    }
}
