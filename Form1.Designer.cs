namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homepanel = new System.Windows.Forms.Panel();
            this.homelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.musicpanel = new System.Windows.Forms.Panel();
            this.musiclabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.playlistpanel = new System.Windows.Forms.Panel();
            this.playlistlabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lovepanel = new System.Windows.Forms.Panel();
            this.lovelabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.loveUC1 = new MusicPlayer.UC.LoveUC();
            this.playlistUC1 = new MusicPlayer.UC.PlaylistUC();
            this.musicUC1 = new MusicPlayer.UC.MusicUC();
            this.homeUC1 = new MusicPlayer.UC.HomeUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.homepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.musicpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.playlistpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.lovepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musify";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homeUC1);
            this.panel2.Controls.Add(this.musicUC1);
            this.panel2.Controls.Add(this.playlistUC1);
            this.panel2.Controls.Add(this.loveUC1);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 801);
            this.panel2.TabIndex = 2;
            // 
            // homepanel
            // 
            this.homepanel.Controls.Add(this.homelabel);
            this.homepanel.Controls.Add(this.pictureBox2);
            this.homepanel.Controls.Add(this.panel3);
            this.homepanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homepanel.Location = new System.Drawing.Point(3, 3);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(125, 73);
            this.homepanel.TabIndex = 0;
            this.homepanel.Click += new System.EventHandler(this.homepanel_Click);
            // 
            // homelabel
            // 
            this.homelabel.AutoSize = true;
            this.homelabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.homelabel.Location = new System.Drawing.Point(32, 54);
            this.homelabel.Name = "homelabel";
            this.homelabel.Size = new System.Drawing.Size(54, 19);
            this.homelabel.TabIndex = 2;
            this.homelabel.Text = "Home";
            this.homelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homelabel.Click += new System.EventHandler(this.homepanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.homepanel_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(131, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 73);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.homepanel);
            this.flowLayoutPanel1.Controls.Add(this.musicpanel);
            this.flowLayoutPanel1.Controls.Add(this.playlistpanel);
            this.flowLayoutPanel1.Controls.Add(this.lovepanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 850);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(525, 81);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // musicpanel
            // 
            this.musicpanel.Controls.Add(this.musiclabel);
            this.musicpanel.Controls.Add(this.pictureBox3);
            this.musicpanel.Controls.Add(this.panel6);
            this.musicpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicpanel.Location = new System.Drawing.Point(134, 3);
            this.musicpanel.Name = "musicpanel";
            this.musicpanel.Size = new System.Drawing.Size(125, 73);
            this.musicpanel.TabIndex = 3;
            this.musicpanel.Click += new System.EventHandler(this.musicpanel_Click);
            // 
            // musiclabel
            // 
            this.musiclabel.AutoSize = true;
            this.musiclabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiclabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.musiclabel.Location = new System.Drawing.Point(32, 54);
            this.musiclabel.Name = "musiclabel";
            this.musiclabel.Size = new System.Drawing.Size(52, 19);
            this.musiclabel.TabIndex = 2;
            this.musiclabel.Text = "Music";
            this.musiclabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musiclabel.Click += new System.EventHandler(this.musicpanel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.musicpanel_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(131, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 73);
            this.panel6.TabIndex = 1;
            // 
            // playlistpanel
            // 
            this.playlistpanel.Controls.Add(this.playlistlabel);
            this.playlistpanel.Controls.Add(this.pictureBox4);
            this.playlistpanel.Controls.Add(this.panel8);
            this.playlistpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistpanel.Location = new System.Drawing.Point(265, 3);
            this.playlistpanel.Name = "playlistpanel";
            this.playlistpanel.Size = new System.Drawing.Size(125, 73);
            this.playlistpanel.TabIndex = 3;
            this.playlistpanel.Click += new System.EventHandler(this.playlistpanel_Click);
            // 
            // playlistlabel
            // 
            this.playlistlabel.AutoSize = true;
            this.playlistlabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistlabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.playlistlabel.Location = new System.Drawing.Point(32, 54);
            this.playlistlabel.Name = "playlistlabel";
            this.playlistlabel.Size = new System.Drawing.Size(60, 19);
            this.playlistlabel.TabIndex = 2;
            this.playlistlabel.Text = "Playlist";
            this.playlistlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playlistlabel.Click += new System.EventHandler(this.playlistpanel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.playlistpanel_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(131, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 73);
            this.panel8.TabIndex = 1;
            // 
            // lovepanel
            // 
            this.lovepanel.BackColor = System.Drawing.Color.White;
            this.lovepanel.Controls.Add(this.lovelabel);
            this.lovepanel.Controls.Add(this.pictureBox5);
            this.lovepanel.Controls.Add(this.panel10);
            this.lovepanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lovepanel.Location = new System.Drawing.Point(396, 3);
            this.lovepanel.Name = "lovepanel";
            this.lovepanel.Size = new System.Drawing.Size(125, 73);
            this.lovepanel.TabIndex = 3;
            this.lovepanel.Click += new System.EventHandler(this.lovepanel_Click);
            // 
            // lovelabel
            // 
            this.lovelabel.AutoSize = true;
            this.lovelabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lovelabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lovelabel.Location = new System.Drawing.Point(38, 54);
            this.lovelabel.Name = "lovelabel";
            this.lovelabel.Size = new System.Drawing.Size(43, 19);
            this.lovelabel.TabIndex = 2;
            this.lovelabel.Text = "Love";
            this.lovelabel.Click += new System.EventHandler(this.lovepanel_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.lovepanel_Click);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(131, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(125, 73);
            this.panel10.TabIndex = 1;
            // 
            // loveUC1
            // 
            this.loveUC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loveUC1.Location = new System.Drawing.Point(0, 0);
            this.loveUC1.Name = "loveUC1";
            this.loveUC1.Size = new System.Drawing.Size(525, 800);
            this.loveUC1.TabIndex = 0;
            // 
            // playlistUC1
            // 
            this.playlistUC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.playlistUC1.Location = new System.Drawing.Point(0, 0);
            this.playlistUC1.Name = "playlistUC1";
            this.playlistUC1.Size = new System.Drawing.Size(525, 800);
            this.playlistUC1.TabIndex = 1;
            // 
            // musicUC1
            // 
            this.musicUC1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.musicUC1.Location = new System.Drawing.Point(0, 0);
            this.musicUC1.Name = "musicUC1";
            this.musicUC1.Size = new System.Drawing.Size(525, 800);
            this.musicUC1.TabIndex = 2;
            // 
            // homeUC1
            // 
            this.homeUC1.Location = new System.Drawing.Point(0, 0);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(525, 800);
            this.homeUC1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 932);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.homepanel.ResumeLayout(false);
            this.homepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.musicpanel.ResumeLayout(false);
            this.musicpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.playlistpanel.ResumeLayout(false);
            this.playlistpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.lovepanel.ResumeLayout(false);
            this.lovepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label homelabel;
        private System.Windows.Forms.Panel musicpanel;
        private System.Windows.Forms.Label musiclabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel playlistpanel;
        private System.Windows.Forms.Label playlistlabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel lovepanel;
        private System.Windows.Forms.Label lovelabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel10;
        private UC.HomeUC homeUC1;
        private UC.MusicUC musicUC1;
        private UC.PlaylistUC playlistUC1;
        private UC.LoveUC loveUC1;
    }
}

