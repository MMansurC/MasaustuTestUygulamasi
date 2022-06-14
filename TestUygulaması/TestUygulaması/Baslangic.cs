using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TestUygulaması
{
    public partial class Baslangic : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        public Baslangic()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciGirisi_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            this.Hide();
            ogrenciGiris.Show();
        }

        private void BEUN_Click(object sender, EventArgs e)
        {
            Process.Start("https://w3.beun.edu.tr/");
        }

        private void OgretmenGirisi_Click(object sender, EventArgs e)
        {
            OgretmenGiris ogretmenGiris = new OgretmenGiris();
            this.Hide();
            ogretmenGiris.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
