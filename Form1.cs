using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        readonly FileSystem FS = new FileSystem();
        public Form1()
        {
            InitializeComponent();
            FS.LoadMusic(listMusic);
        }

        private void BtnSelectMusic_Click(object sender, EventArgs e)
        {
            FS.AddMusic(listMusic);
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = FS.GetFilePaths()[listMusic.SelectedIndex];
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void listPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
