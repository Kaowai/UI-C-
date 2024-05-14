namespace MusicPlayer.UC
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbDownload = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbLove = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lbNameSinger = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pbDownload);
            this.panel1.Controls.Add(this.pbPlay);
            this.panel1.Controls.Add(this.pbLove);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.lbNameSinger);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 80);
            this.panel1.TabIndex = 0;
            // 
            // pbDownload
            // 
            this.pbDownload.Image = ((System.Drawing.Image)(resources.GetObject("pbDownload.Image")));
            this.pbDownload.Location = new System.Drawing.Point(448, 41);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(41, 32);
            this.pbDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDownload.TabIndex = 6;
            this.pbDownload.TabStop = false;
            // 
            // pbPlay
            // 
            this.pbPlay.Image = global::MusicPlayer.Properties.Resources.Button_Play__Streamline_Ultimate;
            this.pbPlay.Location = new System.Drawing.Point(401, 41);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(41, 32);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPlay.TabIndex = 5;
            this.pbPlay.TabStop = false;
            // 
            // pbLove
            // 
            this.pbLove.Image = global::MusicPlayer.Properties.Resources.heart;
            this.pbLove.Location = new System.Drawing.Point(358, 45);
            this.pbLove.Name = "pbLove";
            this.pbLove.Size = new System.Drawing.Size(37, 25);
            this.pbLove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLove.TabIndex = 4;
            this.pbLove.TabStop = false;
            this.pbLove.Click += new System.EventHandler(this.pbLove_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(311, 41);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(41, 32);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            // 
            // lbNameSinger
            // 
            this.lbNameSinger.AutoSize = true;
            this.lbNameSinger.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSinger.Location = new System.Drawing.Point(109, 48);
            this.lbNameSinger.Name = "lbNameSinger";
            this.lbNameSinger.Size = new System.Drawing.Size(105, 19);
            this.lbNameSinger.TabIndex = 2;
            this.lbNameSinger.Text = "Jack đẹp trai";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(109, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(213, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Bạc phận bài hát hay nhất";
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 74);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Music";
            this.Size = new System.Drawing.Size(500, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameSinger;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbLove;
        private System.Windows.Forms.PictureBox pbDownload;
        private System.Windows.Forms.PictureBox pbPlay;
    }
}
