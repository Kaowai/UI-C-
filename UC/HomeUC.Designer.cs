namespace MusicPlayer.UC
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Recently = new System.Windows.Forms.TabPage();
            this.download = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.musicHome1 = new MusicPlayer.UC.MusicHome();
            this.musicHome2 = new MusicPlayer.UC.MusicHome();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Recently.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 800);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Recently);
            this.tabControl1.Controls.Add(this.download);
            this.tabControl1.Location = new System.Drawing.Point(3, 506);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 291);
            this.tabControl1.TabIndex = 2;
            // 
            // Recently
            // 
            this.Recently.AutoScroll = true;
            this.Recently.Controls.Add(this.flowLayoutPanel1);
            this.Recently.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recently.Location = new System.Drawing.Point(4, 25);
            this.Recently.Name = "Recently";
            this.Recently.Padding = new System.Windows.Forms.Padding(3);
            this.Recently.Size = new System.Drawing.Size(511, 262);
            this.Recently.TabIndex = 0;
            this.Recently.Text = "Recently";
            this.Recently.UseVisualStyleBackColor = true;
            // 
            // download
            // 
            this.download.AutoScroll = true;
            this.download.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.Location = new System.Drawing.Point(4, 25);
            this.download.Name = "download";
            this.download.Padding = new System.Windows.Forms.Padding(3);
            this.download.Size = new System.Drawing.Size(511, 262);
            this.download.TabIndex = 1;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(525, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.musicHome1);
            this.flowLayoutPanel1.Controls.Add(this.musicHome2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 253);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // musicHome1
            // 
            this.musicHome1.Location = new System.Drawing.Point(3, 4);
            this.musicHome1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musicHome1.Name = "musicHome1";
            this.musicHome1.Size = new System.Drawing.Size(91, 167);
            this.musicHome1.TabIndex = 0;
            // 
            // musicHome2
            // 
            this.musicHome2.Location = new System.Drawing.Point(100, 4);
            this.musicHome2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musicHome2.Name = "musicHome2";
            this.musicHome2.Size = new System.Drawing.Size(93, 167);
            this.musicHome2.TabIndex = 1;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(525, 800);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Recently.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Recently;
        private System.Windows.Forms.TabPage download;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MusicHome musicHome1;
        private MusicHome musicHome2;
    }
}
