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
    public partial class OgrenciGiris : Form
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
        public OgrenciGiris()
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
        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            Randomla();
        }
        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://w3.beun.edu.tr/");
        }
        public static string ogrno, ogradi;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestUygulamasiDatabase.accdb");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("SELECT TCKimlik,OgrenciNo,AdSoyad FROM Ogrenci WHERE TCKimlik=@tc AND OgrenciNo=@ogrno", baglanti);
            sorgu.Parameters.AddWithValue("@tc", TCKimlik.Text);
            sorgu.Parameters.AddWithValue("@ogrno", OgrenciNumarasi.Text);
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
                    OgrenciAnaSayfa ogrenciAnaSayfa=new OgrenciAnaSayfa();;
                    ogrenciAnaSayfa.OgrenciAdi.Text = dr.GetValue(2).ToString();
                    ogrenciAnaSayfa.OgrenciNo.Text = dr.GetValue(1).ToString();
                    ogradi = dr.GetValue(2).ToString();
                    ogrno = dr.GetValue(1).ToString();
                    this.Hide();
                    ogrenciAnaSayfa.Show();
                }
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("TC Kimlik Numarası ya da Öğrenci Numarası yanlış.");
                Randomla();
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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

        private void GoBack_Click(object sender, EventArgs e)
        {
            Baslangic baslangic = new Baslangic();
            this.Hide();
            baslangic.Show();
        }
    }
}
