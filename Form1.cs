using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        int pageDisplay = 0;

        public Form1()
        {
            InitializeComponent();
            pageDisplay = 0;
            homeUC1.BringToFront();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void disable_button(int lastPage)
        {
            if (lastPage == 0)
            {
                homelabel.Font = new Font("Poppins", 10, FontStyle.Regular);
                homelabel.ForeColor = SystemColors.AppWorkspace;
            } else if (lastPage == 1)
            {
                musiclabel.Font = new Font("Poppins", 10, FontStyle.Regular);
                musiclabel.ForeColor = SystemColors.AppWorkspace;
            } else if (lastPage == 2)
            {
                playlistlabel.Font = new Font("Poppins", 10, FontStyle.Regular);
                playlistlabel.ForeColor = SystemColors.AppWorkspace;
            } else
            {
                lovelabel.Font = new Font("Poppins", 10, FontStyle.Regular);
                lovelabel.ForeColor = SystemColors.AppWorkspace;
            }
        }

        private void homepanel_Click(object sender, EventArgs e)
        {
            disable_button(pageDisplay);
            pageDisplay = 0;
            homelabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            homelabel.ForeColor = Color.FromArgb(29, 185, 84);
            homeUC1.BringToFront();
        }

        private void musicpanel_Click(object sender, EventArgs e)
        {
            disable_button(pageDisplay);
            pageDisplay = 1;
            musiclabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            musiclabel.ForeColor = Color.FromArgb(29, 185, 84);
            musicUC1.BringToFront();
        }

        private void playlistpanel_Click(object sender, EventArgs e)
        {
            disable_button(pageDisplay);
            pageDisplay = 2;
            playlistlabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            playlistlabel.ForeColor = Color.FromArgb(29, 185, 84);
            playlistUC1.BringToFront();
        }

        private void lovepanel_Click(object sender, EventArgs e)
        {
            disable_button(pageDisplay);
            pageDisplay = 3;
            lovelabel.Font = new Font("Poppins", 10, FontStyle.Bold);
            lovelabel.ForeColor = Color.FromArgb(29, 185, 84);
            loveUC1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeUC1.Show();
            
        }
    }

}
