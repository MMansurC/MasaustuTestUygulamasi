
namespace TestUygulaması
{
    partial class OgrenciAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OgrenciAdi = new System.Windows.Forms.Label();
            this.OgrenciNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cikis = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinalNotu = new System.Windows.Forms.Label();
            this.VizeNotu = new System.Windows.Forms.Label();
            this.Faktif = new System.Windows.Forms.Label();
            this.Vaktif = new System.Windows.Forms.Label();
            this.FGirisHak = new System.Windows.Forms.Label();
            this.VGirisHak = new System.Windows.Forms.Label();
            this.BtnFinalGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVizeGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDevam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.OgrenciAdi);
            this.panel1.Controls.Add(this.OgrenciNo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 70);
            this.panel1.TabIndex = 1;
            // 
            // OgrenciAdi
            // 
            this.OgrenciAdi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciAdi.Location = new System.Drawing.Point(46, 15);
            this.OgrenciAdi.Name = "OgrenciAdi";
            this.OgrenciAdi.Size = new System.Drawing.Size(308, 30);
            this.OgrenciAdi.TabIndex = 9;
            this.OgrenciAdi.Text = "{Öğrenci Adı}";
            this.OgrenciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciNo.Location = new System.Drawing.Point(47, 41);
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.Size = new System.Drawing.Size(308, 23);
            this.OgrenciNo.TabIndex = 10;
            this.OgrenciNo.Text = "{Öğrenci No}";
            this.OgrenciNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.Cikis.TabIndex = 7;
            this.Cikis.TabStop = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.FinalNotu);
            this.panel2.Controls.Add(this.VizeNotu);
            this.panel2.Controls.Add(this.Faktif);
            this.panel2.Controls.Add(this.Vaktif);
            this.panel2.Controls.Add(this.FGirisHak);
            this.panel2.Controls.Add(this.VGirisHak);
            this.panel2.Controls.Add(this.BtnFinalGiris);
            this.panel2.Controls.Add(this.BtnVizeGiris);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 430);
            this.panel2.TabIndex = 2;
            // 
            // FinalNotu
            // 
            this.FinalNotu.AutoSize = true;
            this.FinalNotu.Location = new System.Drawing.Point(444, 222);
            this.FinalNotu.Name = "FinalNotu";
            this.FinalNotu.Size = new System.Drawing.Size(52, 13);
            this.FinalNotu.TabIndex = 30;
            this.FinalNotu.Text = "FinalNotu";
            this.FinalNotu.Visible = false;
            // 
            // VizeNotu
            // 
            this.VizeNotu.AutoSize = true;
            this.VizeNotu.Location = new System.Drawing.Point(188, 222);
            this.VizeNotu.Name = "VizeNotu";
            this.VizeNotu.Size = new System.Drawing.Size(50, 13);
            this.VizeNotu.TabIndex = 29;
            this.VizeNotu.Text = "VizeNotu";
            this.VizeNotu.Visible = false;
            // 
            // Faktif
            // 
            this.Faktif.AutoSize = true;
            this.Faktif.Location = new System.Drawing.Point(447, 185);
            this.Faktif.Name = "Faktif";
            this.Faktif.Size = new System.Drawing.Size(28, 13);
            this.Faktif.TabIndex = 28;
            this.Faktif.Text = "Aktif";
            this.Faktif.Visible = false;
            // 
            // Vaktif
            // 
            this.Vaktif.AutoSize = true;
            this.Vaktif.Location = new System.Drawing.Point(188, 185);
            this.Vaktif.Name = "Vaktif";
            this.Vaktif.Size = new System.Drawing.Size(28, 13);
            this.Vaktif.TabIndex = 27;
            this.Vaktif.Text = "Aktif";
            this.Vaktif.Visible = false;
            // 
            // FGirisHak
            // 
            this.FGirisHak.Location = new System.Drawing.Point(450, 164);
            this.FGirisHak.Name = "FGirisHak";
            this.FGirisHak.Size = new System.Drawing.Size(247, 13);
            this.FGirisHak.TabIndex = 26;
            this.FGirisHak.Text = "HATA";
            this.FGirisHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VGirisHak
            // 
            this.VGirisHak.Location = new System.Drawing.Point(191, 164);
            this.VGirisHak.Name = "VGirisHak";
            this.VGirisHak.Size = new System.Drawing.Size(250, 13);
            this.VGirisHak.TabIndex = 25;
            this.VGirisHak.Text = "HATA";
            this.VGirisHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFinalGiris
            // 
            this.BtnFinalGiris.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.BtnFinalGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(240)))), ((int)(((byte)(164)))));
            this.BtnFinalGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFinalGiris.BackgroundImage")));
            this.BtnFinalGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFinalGiris.BorderRadius = 0;
            this.BtnFinalGiris.ButtonText = "FİNAL SINAVINA GİR";
            this.BtnFinalGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinalGiris.DisabledColor = System.Drawing.Color.LightGray;
            this.BtnFinalGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnFinalGiris.Iconimage = null;
            this.BtnFinalGiris.Iconimage_right = null;
            this.BtnFinalGiris.Iconimage_right_Selected = null;
            this.BtnFinalGiris.Iconimage_Selected = null;
            this.BtnFinalGiris.IconMarginLeft = 0;
            this.BtnFinalGiris.IconMarginRight = 0;
            this.BtnFinalGiris.IconRightVisible = true;
            this.BtnFinalGiris.IconRightZoom = 0D;
            this.BtnFinalGiris.IconVisible = true;
            this.BtnFinalGiris.IconZoom = 90D;
            this.BtnFinalGiris.IsTab = false;
            this.BtnFinalGiris.Location = new System.Drawing.Point(447, 185);
            this.BtnFinalGiris.Name = "BtnFinalGiris";
            this.BtnFinalGiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(240)))), ((int)(((byte)(164)))));
            this.BtnFinalGiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(184)))));
            this.BtnFinalGiris.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnFinalGiris.selected = false;
            this.BtnFinalGiris.Size = new System.Drawing.Size(250, 50);
            this.BtnFinalGiris.TabIndex = 24;
            this.BtnFinalGiris.Text = "FİNAL SINAVINA GİR";
            this.BtnFinalGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnFinalGiris.Textcolor = System.Drawing.Color.Black;
            this.BtnFinalGiris.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFinalGiris.Click += new System.EventHandler(this.BtnFinalGiris_Click);
            // 
            // BtnVizeGiris
            // 
            this.BtnVizeGiris.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.BtnVizeGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(240)))), ((int)(((byte)(164)))));
            this.BtnVizeGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVizeGiris.BackgroundImage")));
            this.BtnVizeGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVizeGiris.BorderRadius = 0;
            this.BtnVizeGiris.ButtonText = "VİZE SINAVINA GİR";
            this.BtnVizeGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVizeGiris.DisabledColor = System.Drawing.Color.LightGray;
            this.BtnVizeGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVizeGiris.Iconimage = null;
            this.BtnVizeGiris.Iconimage_right = null;
            this.BtnVizeGiris.Iconimage_right_Selected = null;
            this.BtnVizeGiris.Iconimage_Selected = null;
            this.BtnVizeGiris.IconMarginLeft = 0;
            this.BtnVizeGiris.IconMarginRight = 0;
            this.BtnVizeGiris.IconRightVisible = true;
            this.BtnVizeGiris.IconRightZoom = 0D;
            this.BtnVizeGiris.IconVisible = true;
            this.BtnVizeGiris.IconZoom = 90D;
            this.BtnVizeGiris.IsTab = false;
            this.BtnVizeGiris.Location = new System.Drawing.Point(191, 185);
            this.BtnVizeGiris.Name = "BtnVizeGiris";
            this.BtnVizeGiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(240)))), ((int)(((byte)(164)))));
            this.BtnVizeGiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(255)))), ((int)(((byte)(184)))));
            this.BtnVizeGiris.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnVizeGiris.selected = false;
            this.BtnVizeGiris.Size = new System.Drawing.Size(250, 50);
            this.BtnVizeGiris.TabIndex = 23;
            this.BtnVizeGiris.Text = "VİZE SINAVINA GİR";
            this.BtnVizeGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVizeGiris.Textcolor = System.Drawing.Color.Black;
            this.BtnVizeGiris.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVizeGiris.Click += new System.EventHandler(this.BtnVizeGiris_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblDevam);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 23);
            this.panel3.TabIndex = 31;
            this.panel3.Visible = false;
            // 
            // lblDevam
            // 
            this.lblDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDevam.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDevam.Location = new System.Drawing.Point(10, 10);
            this.lblDevam.Name = "lblDevam";
            this.lblDevam.Size = new System.Drawing.Size(880, 480);
            this.lblDevam.TabIndex = 0;
            this.lblDevam.Text = "Devam Etmek İçin Tıklayın";
            this.lblDevam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDevam.Click += new System.EventHandler(this.lblDevam_Click);
            // 
            // OgrenciAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciAnaSayfa";
            this.Load += new System.EventHandler(this.OgrenciAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cikis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label OgrenciAdi;
        public System.Windows.Forms.Label OgrenciNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Faktif;
        private System.Windows.Forms.Label Vaktif;
        private System.Windows.Forms.Label FinalNotu;
        private System.Windows.Forms.Label VizeNotu;
        public Bunifu.Framework.UI.BunifuFlatButton BtnFinalGiris;
        public Bunifu.Framework.UI.BunifuFlatButton BtnVizeGiris;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox Cikis;
        public System.Windows.Forms.Label FGirisHak;
        public System.Windows.Forms.Label VGirisHak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDevam;
    }
}