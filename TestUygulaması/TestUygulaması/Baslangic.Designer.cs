
namespace TestUygulaması
{
    partial class Baslangic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            this.OgrenciGirisi = new System.Windows.Forms.Button();
            this.OgretmenGirisi = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BEUN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BEUN)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciGirisi
            // 
            this.OgrenciGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(227)))), ((int)(((byte)(244)))));
            this.OgrenciGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OgrenciGirisi.BackgroundImage")));
            this.OgrenciGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OgrenciGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrenciGirisi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciGirisi.Location = new System.Drawing.Point(10, 10);
            this.OgrenciGirisi.Name = "OgrenciGirisi";
            this.OgrenciGirisi.Size = new System.Drawing.Size(200, 50);
            this.OgrenciGirisi.TabIndex = 0;
            this.OgrenciGirisi.Text = "Öğrenci Girişi";
            this.OgrenciGirisi.UseVisualStyleBackColor = false;
            this.OgrenciGirisi.Click += new System.EventHandler(this.OgrenciGirisi_Click);
            // 
            // OgretmenGirisi
            // 
            this.OgretmenGirisi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OgretmenGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OgretmenGirisi.BackgroundImage")));
            this.OgretmenGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OgretmenGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgretmenGirisi.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgretmenGirisi.ForeColor = System.Drawing.Color.White;
            this.OgretmenGirisi.Location = new System.Drawing.Point(216, 10);
            this.OgretmenGirisi.Name = "OgretmenGirisi";
            this.OgretmenGirisi.Size = new System.Drawing.Size(200, 50);
            this.OgretmenGirisi.TabIndex = 1;
            this.OgretmenGirisi.Text = "Öğretmen Girişi";
            this.OgretmenGirisi.UseVisualStyleBackColor = false;
            this.OgretmenGirisi.Click += new System.EventHandler(this.OgretmenGirisi_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Cikis.Image")));
            this.Cikis.Location = new System.Drawing.Point(870, 5);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(25, 25);
            this.Cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cikis.TabIndex = 3;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.OgretmenGirisi);
            this.panel2.Controls.Add(this.OgrenciGirisi);
            this.panel2.Location = new System.Drawing.Point(221, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 70);
            this.panel2.TabIndex = 4;
            // 
            // BEUN
            // 
            this.BEUN.BackColor = System.Drawing.Color.Transparent;
            this.BEUN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEUN.Image = ((System.Drawing.Image)(resources.GetObject("BEUN.Image")));
            this.BEUN.Location = new System.Drawing.Point(12, 12);
            this.BEUN.Name = "BEUN";
            this.BEUN.Size = new System.Drawing.Size(80, 80);
            this.BEUN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BEUN.TabIndex = 8;
            this.BEUN.TabStop = false;
            this.BEUN.Click += new System.EventHandler(this.BEUN_Click);
            // 
            // Baslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.BEUN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cikis);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Baslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Baslangic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BEUN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OgrenciGirisi;
        private System.Windows.Forms.Button OgretmenGirisi;
        private System.Windows.Forms.PictureBox Cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BEUN;
    }
}

