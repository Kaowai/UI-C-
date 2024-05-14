using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.UC
{
    public partial class Love : UserControl
    {
        bool isPlaying = false;
        public Love()
        {
            InitializeComponent();
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {

            Image image;
            if (isPlaying)
            {
                // Xử lý bỏ phát bài hát ở đây
                image = Properties.Resources.Button_Play__Streamline_Ultimate;
                pbPlay.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else
            {
                // Xử lý phát bài hát ở đây
                image = Properties.Resources.sound;
                pbPlay.SizeMode = PictureBoxSizeMode.Zoom;

            }
            pbPlay.Image = image;
            isPlaying = !isPlaying;
        }
    }
}
