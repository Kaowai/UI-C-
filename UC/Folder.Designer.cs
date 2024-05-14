namespace MusicPlayer.UC
{
    partial class Folder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Folder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNameFolder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbDelete);
            this.panel1.Controls.Add(this.pbPlay);
            this.panel1.Controls.Add(this.labelNameFolder);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 0;
            // 
            // labelNameFolder
            // 
            this.labelNameFolder.AutoSize = true;
            this.labelNameFolder.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameFolder.Location = new System.Drawing.Point(68, 16);
            this.labelNameFolder.Name = "labelNameFolder";
            this.labelNameFolder.Size = new System.Drawing.Size(96, 22);
            this.labelNameFolder.TabIndex = 1;
            this.labelNameFolder.Text = "Jack của em";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayer.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbPlay
            // 
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(419, 10);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(31, 31);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPlay.TabIndex = 2;
            this.pbPlay.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = ((System.Drawing.Image)(resources.GetObject("pbDelete.Image")));
            this.pbDelete.Location = new System.Drawing.Point(456, 10);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(31, 31);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDelete.TabIndex = 3;
            this.pbDelete.TabStop = false;
            // 
            // Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Folder";
            this.Size = new System.Drawing.Size(500, 50);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNameFolder;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbPlay;
    }
}
