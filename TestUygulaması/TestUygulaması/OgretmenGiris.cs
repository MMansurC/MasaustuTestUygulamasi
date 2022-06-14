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
    public partial class OgretmenGiris : Form
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
        public OgretmenGiris()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void Randomla()
        {
            Random rastgele = new Random();
            int sayi;
            sayi = rastgele.Next(1000, 9999);
            Gvnlk.Text = sayi.ToString();
        }
        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            Randomla();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BEUN_Click(object sender, EventArgs e)
        {
            Process.Start("https://w3.beun.edu.tr/");
        }

        private void GvnlkBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void OgrenciNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void TCKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestUygulamasiDatabase.accdb");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("SELECT TCKimlik,Sifre,AdSoyad,DersAdi FROM Egitmen WHERE TCKimlik=@tc AND Sifre=@sif", baglanti);
            sorgu.Parameters.AddWithValue("@tc", TCKimlik.Text);
            sorgu.Parameters.AddWithValue("@sif", Sifre.Text);
            OleDbDataReader dr;
            dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                if (GvnlkBox.Text == "")
                {
                    MessageBox.Show("Güvenlik kodu boş bırakılamaz.");
                    Randomla();
                }
                else if (GvnlkBox.Text != Gvnlk.Text)
                {
                    MessageBox.Show("Güvenlik kodunu hatalı girdiniz.");
                    Randomla();
                }
                else
                {
                    OgretmenAnaSayfa ogretmenAnaSayfa = new OgretmenAnaSayfa();
                    ogretmenAnaSayfa.OgretmenAdi.Text = dr.GetValue(2).ToString();
                    ogretmenAnaSayfa.DersAdi.Text = dr.GetValue(3).ToString();
                    this.Hide();
                    ogretmenAnaSayfa.Show();
                }
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("TC Kimlik Numarası ya da Şifre yanlış.");
                Randomla();
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Baslangic baslangic = new Baslangic();
            this.Hide();
            baslangic.Show();
        }
    }
}
