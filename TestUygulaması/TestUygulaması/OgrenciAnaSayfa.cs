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
using System.Data.OleDb;

namespace TestUygulaması
{
    public partial class OgrenciAnaSayfa : Form
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
        public OgrenciAnaSayfa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public static string vizetik = "0", finaltik = "0";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestUygulamasiDatabase.accdb");

        private void sinavlarikontrol()
        {
            baglanti.Open();
            OleDbCommand vizesorgu = new OleDbCommand("SELECT VizeAktif FROM Sistem WHERE VizeAktif=@vaktif", baglanti);
            OleDbCommand finalsorgu = new OleDbCommand("SELECT FinalAktif FROM Sistem WHERE FinalAktif=@faktif", baglanti);
            OleDbCommand notgetir = new OleDbCommand("SELECT Vize,Final FROM Ogrenci WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
            OleDbDataReader dr;
            vizesorgu.Parameters.AddWithValue("@vaktif", Vaktif.Text);
            finalsorgu.Parameters.AddWithValue("@faktif", Faktif.Text);
            int VizeAktif = 10, FinalAktif = 10;
            dr = vizesorgu.ExecuteReader();
            if (dr.Read())
            {
                VizeAktif = 1;
            }
            else
            {
                VizeAktif = 0;
            }
            dr = finalsorgu.ExecuteReader();
            if (dr.Read())
            {
                FinalAktif = 1;
            }
            else
            {
                FinalAktif = 0;
            }

            OleDbCommand girishak = new OleDbCommand("SELECT VizeGiris,FinalGiris FROM Ogrenci WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
            dr = girishak.ExecuteReader();
            if (dr.Read())
            {
                VGirisHak.Text = dr[0].ToString();
                FGirisHak.Text = dr[1].ToString();
            }
            dr = notgetir.ExecuteReader();
            if (dr.Read())
            {
                VizeNotu.Text = dr[0].ToString();
                FinalNotu.Text = dr[1].ToString();
            }
            baglanti.Close();

            if (VizeAktif == 0)
            {
                BtnVizeGiris.Text = "VİZE HENÜZ AKTİF DEĞİL";
                BtnVizeGiris.Cursor = default;
                BtnVizeGiris.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                BtnVizeGiris.OnHovercolor = Color.FromArgb(255, 240, 187, 204);
                BtnVizeGiris.Activecolor = Color.FromArgb(255, 240, 187, 204);
                BtnVizeGiris.Enabled = false;
            }
            else
            {
                if (VGirisHak.Text == "Girildi")
                {
                    BtnVizeGiris.Text = "Vize Notunuz: " + VizeNotu.Text + "";
                    BtnVizeGiris.Cursor = default;
                    BtnVizeGiris.Normalcolor = Color.FromArgb(255, 200, 200, 200);
                    BtnVizeGiris.OnHovercolor = Color.FromArgb(255, 200, 200, 200);
                    BtnVizeGiris.Activecolor = Color.FromArgb(255, 200, 200, 200);
                    BtnVizeGiris.Enabled = false;
                }
            }
            if (FinalAktif == 0)
            {
                BtnFinalGiris.Text = "FİNAL HENÜZ AKTİF DEĞİL";
                BtnFinalGiris.Cursor = default;
                BtnFinalGiris.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                BtnFinalGiris.OnHovercolor = Color.FromArgb(255, 240, 187, 204);
                BtnFinalGiris.Activecolor = Color.FromArgb(255, 240, 187, 204);
                BtnFinalGiris.Enabled = false;
            }
            else
            {
                if (FGirisHak.Text == "Girildi")
                {
                    BtnFinalGiris.Text = "Final Notunuz: " + FinalNotu.Text + "";
                    BtnFinalGiris.Cursor = default;
                    BtnFinalGiris.Normalcolor = Color.FromArgb(255, 200, 200, 200);
                    BtnFinalGiris.OnHovercolor = Color.FromArgb(255, 200, 200, 200);
                    BtnFinalGiris.Activecolor = Color.FromArgb(255, 200, 200, 200);
                    BtnFinalGiris.Enabled = false;
                }
            }
        }

        private void OgrenciAnaSayfa_Load(object sender, EventArgs e)
        {
            sinavlarikontrol();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Baslangic baslangic = new Baslangic();
            this.Hide();
            baslangic.Show();
        }

        private void BtnVizeGiris_Click(object sender, EventArgs e)
        {
            SinavEkranı sinavekrani = new SinavEkranı();
            panel3.Visible = true;
            panel3.Size = new Size(900, 500);
            vizetik = "1";
            sinavekrani.ShowDialog();
        }

        private void BtnFinalGiris_Click(object sender, EventArgs e)
        {
            SinavEkranı sinavekrani = new SinavEkranı();
            panel3.Visible = true;
            panel3.Size = new Size(900, 500);
            finaltik = "1";
            sinavekrani.ShowDialog();
        }

        private void lblDevam_Click(object sender, EventArgs e)
        {
            SinavEkranı sinavekrani = new SinavEkranı();
            Cikis.Visible = true;
            sinavlarikontrol();
            sinavekrani.timer1.Stop();

            if (vizetik == "1")
            {
                BtnVizeGiris.Text = "Vize Notunuz: " + VizeNotu.Text + "";
                BtnVizeGiris.Cursor = default;
                BtnVizeGiris.Normalcolor = Color.FromArgb(255, 200, 200, 200);
                BtnVizeGiris.OnHovercolor = Color.FromArgb(255, 200, 200, 200);
                BtnVizeGiris.Activecolor = Color.FromArgb(255, 200, 200, 200);
                panel3.Visible = false;
                vizetik = "0";
                
            }
            else if (finaltik == "1")
            {
                BtnFinalGiris.Text = "Final Notunuz: " + FinalNotu.Text + "";
                BtnFinalGiris.Cursor = default;
                BtnFinalGiris.Normalcolor = Color.FromArgb(255, 200, 200, 200);
                BtnFinalGiris.OnHovercolor = Color.FromArgb(255, 200, 200, 200);
                BtnFinalGiris.Activecolor = Color.FromArgb(255, 200, 200, 200);
                panel3.Visible = false;
                finaltik = "0";
            }
            
        }
    }
}
