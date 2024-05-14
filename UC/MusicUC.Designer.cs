namespace MusicPlayer.UC
{
    partial class MusicUC
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
            this.btnAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.music1 = new MusicPlayer.UC.Music();
            this.music2 = new MusicPlayer.UC.Music();
            this.music3 = new MusicPlayer.UC.Music();
            this.music4 = new MusicPlayer.UC.Music();
            this.music5 = new MusicPlayer.UC.Music();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnAll.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(3, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(113, 44);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAll);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 51);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(122, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nhạc cổ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(241, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nhạc Ballad";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(6, 60);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(516, 38);
            this.tbSearch.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.music1);
            this.flowLayoutPanel2.Controls.Add(this.music2);
            this.flowLayoutPanel2.Controls.Add(this.music3);
            this.flowLayoutPanel2.Controls.Add(this.music4);
            this.flowLayoutPanel2.Controls.Add(this.music5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 104);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(516, 693);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // music1
            // 
            this.music1.Location = new System.Drawing.Point(3, 3);
            this.music1.Name = "music1";
            this.music1.Size = new System.Drawing.Size(500, 80);
            this.music1.TabIndex = 0;
            // 
            // music2
            // 
            this.music2.Location = new System.Drawing.Point(3, 89);
            this.music2.Name = "music2";
            this.music2.Size = new System.Drawing.Size(500, 80);
            this.music2.TabIndex = 1;
            // 
            // music3
            // 
            this.music3.Location = new System.Drawing.Point(3, 175);
            this.music3.Name = "music3";
            this.music3.Size = new System.Drawing.Size(500, 80);
            this.music3.TabIndex = 2;
            // 
            // music4
            // 
            this.music4.Location = new System.Drawing.Point(3, 261);
            this.music4.Name = "music4";
            this.music4.Size = new System.Drawing.Size(500, 80);
            this.music4.TabIndex = 3;
            // 
            // music5
            // 
            this.music5.Location = new System.Drawing.Point(3, 347);
            this.music5.Name = "music5";
            this.music5.Size = new System.Drawing.Size(500, 80);
            this.music5.TabIndex = 4;
            // 
            // MusicUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MusicUC";
            this.Size = new System.Drawing.Size(525, 800);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Music music1;
        private Music music2;
        private Music music3;
        private Music music4;
        private Music music5;
    }
}
