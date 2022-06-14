using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestUygulaması
{
    public partial class OgretmenAnaSayfa : Form
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
        public OgretmenAnaSayfa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestUygulamasiDatabase.accdb");

        private int vizesekme = 0, finalsekme = 0;
        private string V = "Deaktif", F = "Deaktif";
        DataTable tablo = new DataTable();

        private void VizeFinalGetir()
        {
            lblSinavAyar.Visible = true;
            lblSoruSayisi.Visible = true;
            soruSayisiBox.Visible = true;
            CheckBox1.Visible = true;
            BtnSinavActivate.Visible = true;
            lblSoruGirisi.Visible = true;
            lblToplamSoruSayisi.Visible = true;
            toplamSoruSayisi.Visible = true;
            SoruGirisi.Visible = true;
            lblDogruCevap.Visible = true;
            DogruCevapGirisi.Visible = true;
            lblYanlisCevaplar.Visible = true;
            YanlisCevap1.Visible = true;
            YanlisCevap2.Visible = true;
            YanlisCevap3.Visible = true;
            YanlisCevap4.Visible = true;
            BtnSoruEkle.Visible = true;
            label1.Visible = true;
            lblSure.Visible = true;
            SureBox.Visible = true;
            label2.Visible = true;
            DigerIslemler.Visible = true;
            panel3.Visible = false;
            lblSecilenBilgisi.Text = "Henüz seçilmedi";
            secilen.Text = "{x}";
            SoruGirisi2.Text = "";
            DogruCevapGirisi2.Text = "";
            YanlisCevap1_2.Text = "";
            YanlisCevap2_2.Text = "";
            YanlisCevap3_2.Text = "";
            YanlisCevap4_2.Text = "";
        }

        int sorusayi, n, silinensoru, silinendensonraki;
        private void OgretmenAnaSayfa_Load(object sender, EventArgs e)
        {
            this.matematikTableAdapter.Fill(this.testUygulamasiDatabaseDataSet1.Matematik);
            this.ogrenciTableAdapter.Fill(this.testUygulamasiDatabaseDataSet1.Ogrenci);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT VizeAktif,FinalAktif FROM Sistem", baglanti);
            OleDbCommand sorusayi = new OleDbCommand("SELECT COUNT(*) FROM Matematik", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            OleDbDataReader readforsayi = sorusayi.ExecuteReader();
            while (read.Read())
            {
                V = read[0].ToString();
                F = read[1].ToString();
            }
            read.Close();
            while (readforsayi.Read())
            {
                this.sorusayi = readforsayi.GetInt32(0);
            }
            readforsayi.Close();
            baglanti.Close();
            toplamSoruSayisi.Text = this.sorusayi.ToString();


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
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            dataGrid1.Visible = true;
            lblSinavAyar.Visible = false;
            lblSoruSayisi.Visible = false;
            soruSayisiBox.Visible = false;
            CheckBox1.Visible = false;
            BtnSinavActivate.Visible = false;
            lblSoruGirisi.Visible = false;
            lblToplamSoruSayisi.Visible = false;
            toplamSoruSayisi.Visible = false;
            SoruGirisi.Visible = false;
            lblDogruCevap.Visible = false;
            DogruCevapGirisi.Visible = false;
            lblYanlisCevaplar.Visible = false;
            YanlisCevap1.Visible = false;
            YanlisCevap2.Visible = false;
            YanlisCevap3.Visible = false;
            YanlisCevap4.Visible = false;
            BtnSoruEkle.Visible = false;
            label1.Visible = false;
            lblSure.Visible = false;
            SureBox.Visible = false;
            label2.Visible = false;
            panel3.Visible = false;
            DigerIslemler.Visible = false;
        }
        private void btnVize_Click(object sender, EventArgs e)
        {
            if (V == "Aktif")
            {
                BtnSinavActivate.Text = "VİZEYİ DEAKTİF ET";
                BtnSinavActivate.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 255, 207, 224);
                BtnSinavActivate.Activecolor = Color.FromArgb(255, 240, 187, 204);
            }
            else
            {
                BtnSinavActivate.Text = "VİZEYİ AKTİF ET";
                BtnSinavActivate.Normalcolor = Color.FromArgb(255, 163, 240, 164);
                BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 183, 255, 184);
                BtnSinavActivate.Activecolor = Color.FromArgb(255, 163, 240, 164);
            }
            vizesekme = 1;
            finalsekme = 0;

            if (dataGrid1.Visible == true || panel3.Visible == true)
            {
                dataGrid1.Visible = false;
                panel3.Visible = false;
                VizeFinalGetir();
            }
            lblSinavAyar.Text = "Vize Ayarları";
        }
        private string checkedd;
        private void BtnSinavActivate_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            if (vizesekme == 1)
            {
                if (V == "Deaktif")
                {
                    if (soruSayisiBox.Text == "")
                    {
                        MessageBox.Show("Soru sayısı boş bırakılamaz.", "Hata");
                    }
                    else if (Convert.ToInt32(soruSayisiBox.Text) < 5 || Convert.ToInt32(soruSayisiBox.Text) > 25)
                    {
                        MessageBox.Show("Soru sayısı 5 ile 25 aralığında olmalıdır.", "Hata");
                    }
                    else if (Convert.ToInt32(soruSayisiBox.Text) > Convert.ToInt32(toplamSoruSayisi.Text))
                    {
                        MessageBox.Show("Sorulacak soru sayısı toplam soru sayısından fazla olamaz.", "Hata");
                    }
                    else if (Convert.ToInt32(SureBox.Text) < 60 || Convert.ToInt32(SureBox.Text) > 300)
                    {
                        MessageBox.Show("Soru başına düşen süre 60 ile 300 saniye aralığında olmalıdır.", "Hata");
                    }
                    else if (Convert.ToInt32(SureBox.Text) == 0)
                    {
                        MessageBox.Show("Soru başına düşen süre boş bırakılamaz.", "Hata");
                    }
                    else
                    {
                        baglanti.Open();
                        if (CheckBox1.Checked == true)
                        {
                            checkedd = "Evet";
                        }
                        else
                        {
                            checkedd = "Hayır";
                        }
                        OleDbCommand aktivasyonV = new OleDbCommand("UPDATE Sistem SET VizeAktif='Aktif',VizeSoruSayisi='" + soruSayisiBox.Text + "',VizeSaniye='" + SureBox.Text + "',UcYBirDVize='" + checkedd + "'", baglanti);
                        aktivasyonV.ExecuteNonQuery();
                        MessageBox.Show("Vize Aktif Edildi.", "Vize");
                        BtnSinavActivate.Text = "VİZEYİ DEAKTİF ET";
                        BtnSinavActivate.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                        BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 255, 207, 224);
                        BtnSinavActivate.Activecolor = Color.FromArgb(255, 240, 187, 204);
                        baglanti.Close();
                        V = "Aktif";
                        soruSayisiBox.Text = "";
                        SureBox.Text = "";
                        CheckBox1.Checked = false;
                    }
                }
                else if (V == "Aktif")
                {
                    baglanti.Open();
                    OleDbCommand deaktivasyonV = new OleDbCommand("UPDATE Sistem SET VizeAktif='Deaktif'", baglanti);
                    deaktivasyonV.ExecuteNonQuery();
                    MessageBox.Show("Vize Deaktif Edildi.", "Vize");
                    BtnSinavActivate.Text = "VİZEYİ AKTİF ET";
                    BtnSinavActivate.Normalcolor = Color.FromArgb(255, 163, 240, 164);
                    BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 183, 255, 184);
                    BtnSinavActivate.Activecolor = Color.FromArgb(255, 163, 240, 164);
                    baglanti.Close();
                    V = "Deaktif";
                }
            }
            else if (finalsekme == 1)
            {
                if (F == "Deaktif")
                {
                    if (soruSayisiBox.Text == "")
                    {
                        MessageBox.Show("Soru sayısı boş bırakılamaz.", "Hata");
                    }
                    else if (Convert.ToInt32(soruSayisiBox.Text) < 5 || Convert.ToInt32(soruSayisiBox.Text) > 25)
                    {
                        MessageBox.Show("Soru sayısı 5 ile 25 aralığında olmalıdır.", "Hata");
                    }
                    else if (Convert.ToInt32(soruSayisiBox.Text) > Convert.ToInt32(toplamSoruSayisi.Text))
                    {
                        MessageBox.Show("Sorulacak soru sayısı toplam soru sayısından fazla olamaz.", "Hata");
                    }
                    else if (SureBox.Text == "")
                    {
                        MessageBox.Show("Soru başına düşen süre boş bırakılamaz.", "Hata");
                    }
                    else if (Convert.ToInt32(SureBox.Text) < 60 || Convert.ToInt32(SureBox.Text) > 300)
                    {
                        MessageBox.Show("Soru başına düşen süre 60 ile 300 saniye aralığında olmalıdır.", "Hata");
                    }
                    else
                    {
                        baglanti.Open();
                        if (CheckBox1.Checked == true)
                        {
                            checkedd = "Evet";
                        }
                        else
                        {
                            checkedd = "Hayır";
                        }
                        OleDbCommand aktivasyonF = new OleDbCommand("UPDATE Sistem SET FinalAktif='Aktif',FinalSoruSayisi='" + soruSayisiBox.Text + "',FinalSaniye='" + SureBox.Text + "',UcYBirDFinal='" + checkedd + "'", baglanti);
                        aktivasyonF.ExecuteNonQuery();
                        MessageBox.Show("Final Aktif Edildi.", "Final");
                        BtnSinavActivate.Text = "FİNALİ DEAKTİF ET";
                        BtnSinavActivate.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                        BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 255, 207, 224);
                        BtnSinavActivate.Activecolor = Color.FromArgb(255, 240, 187, 204);
                        baglanti.Close();
                        F = "Aktif";
                        soruSayisiBox.Text = "";
                        SureBox.Text = "";
                        CheckBox1.Checked = false;
                    }
                }
                else if (F == "Aktif")
                {
                    baglanti.Open();
                    OleDbCommand deaktivasyonF = new OleDbCommand("UPDATE Sistem SET FinalAktif='Deaktif'", baglanti);
                    deaktivasyonF.ExecuteNonQuery();
                    MessageBox.Show("Final Deaktif Edildi.", "Final");
                    BtnSinavActivate.Text = "FİNALİ AKTİF ET";
                    BtnSinavActivate.Normalcolor = Color.FromArgb(255, 163, 240, 164);
                    BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 183, 255, 184);
                    BtnSinavActivate.Activecolor = Color.FromArgb(255, 163, 240, 164);
                    baglanti.Close();
                    F = "Deaktif";
                }
            }
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (F == "Aktif")
            {
                BtnSinavActivate.Text = "FİNALİ DEAKTİF ET";
                BtnSinavActivate.Normalcolor = Color.FromArgb(255, 240, 187, 204);
                BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 255, 207, 224);
                BtnSinavActivate.Activecolor = Color.FromArgb(255, 240, 187, 204);
            }
            else
            {
                BtnSinavActivate.Text = "FİNALİ AKTİF ET";
                BtnSinavActivate.Normalcolor = Color.FromArgb(255, 163, 240, 164);
                BtnSinavActivate.OnHovercolor = Color.FromArgb(255, 183, 255, 184);
                BtnSinavActivate.Activecolor = Color.FromArgb(255, 163, 240, 164);
            }
            vizesekme = 0;
            finalsekme = 1;
            if (dataGrid1.Visible == true || panel3.Visible == true)
            {
                dataGrid1.Visible = false;
                panel3.Visible = false;
                VizeFinalGetir();
            }
            lblSinavAyar.Text = "Final Ayarları";
        }

        private void SureBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            lblSinavAyar.Visible = false;
            lblSoruSayisi.Visible = false;
            soruSayisiBox.Visible = false;
            CheckBox1.Visible = false;
            BtnSinavActivate.Visible = false;
            lblSoruGirisi.Visible = false;
            lblToplamSoruSayisi.Visible = false;
            toplamSoruSayisi.Visible = false;
            SoruGirisi.Visible = false;
            lblDogruCevap.Visible = false;
            DogruCevapGirisi.Visible = false;
            lblYanlisCevaplar.Visible = false;
            YanlisCevap1.Visible = false;
            YanlisCevap2.Visible = false;
            YanlisCevap3.Visible = false;
            YanlisCevap4.Visible = false;
            BtnSoruEkle.Visible = false;
            label1.Visible = false;
            lblSure.Visible = false;
            SureBox.Visible = false;
            label2.Visible = false;
            DigerIslemler.Visible = false;
            panel3.Visible = true;
            panel3.Size = new Size(900, 600);
            SoruSecBox.Text = "";
        }


        private void SoruSecBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (SoruSecBox.Text == "")
            {
                MessageBox.Show("Soru numarasını boş bıraktınız.", "Hata");
            }
            else
            {
                OleDbCommand sorusec = new OleDbCommand("SELECT Soru,Dogru,Yanlis1,Yanlis2,Yanlis3,Yanlis4,SoruID FROM Matematik WHERE SoruID=" + Convert.ToInt32(SoruSecBox.Text) + "", baglanti);
                OleDbDataReader read = sorusec.ExecuteReader();
                if (read.Read())
                {
                    lblSecilenBilgisi.Text = SoruSecBox.Text + " numaralı soruya işlem yapılacak.";
                    secilen.Text = SoruSecBox.Text;
                    SoruGirisi2.Text = read[0].ToString();
                    DogruCevapGirisi2.Text = read[1].ToString();
                    YanlisCevap1_2.Text = read[2].ToString();
                    YanlisCevap2_2.Text = read[3].ToString();
                    YanlisCevap3_2.Text = read[4].ToString();
                    YanlisCevap4_2.Text = read[5].ToString();
                }
                else
                {
                    MessageBox.Show("Soru numarasını kontrol edin.", "Hata");
                }
            }
            baglanti.Close();
        }

        private void SecileniGuncelle_Click(object sender, EventArgs e)
        {
            if (secilen.Text == "{x}")
            {
                MessageBox.Show("Önce işlem yapılacak soruyu belirlemelisiniz.", "Uyarı");
            }
            else
            {
                if (SoruGirisi2.Text == "")
                {
                    MessageBox.Show("Soru girişi boş bırakılamaz.", "Hata");
                }
                else if (DogruCevapGirisi2.Text == "")
                {
                    MessageBox.Show("Doğru cevap girişi boş bırakılamaz.", "Hata");
                }
                else if (YanlisCevap1_2.Text == "" || YanlisCevap2_2.Text == "" || YanlisCevap3_2.Text == "" || YanlisCevap4_2.Text == "")
                {
                    MessageBox.Show("4 adet yanlış cevap girilmelidir.", "Hata");
                }
                else
                {
                    baglanti.Open();
                    OleDbCommand soruguncelle = new OleDbCommand("UPDATE Matematik SET Soru='" + SoruGirisi2.Text + "',Dogru='" + DogruCevapGirisi2.Text + "',Yanlis1='" + YanlisCevap1_2.Text + "',Yanlis2='" + YanlisCevap2_2.Text + "',Yanlis3='" + YanlisCevap3_2.Text + "',Yanlis4='" + YanlisCevap4_2.Text + "' WHERE SoruID=" + Convert.ToInt32(secilen.Text) + "", baglanti);
                    soruguncelle.ExecuteNonQuery();
                    yenile();
                    baglanti.Close();
                    MessageBox.Show("Soru başarıyla güncellendi.");
                    SoruGirisi2.Text = "";
                    DogruCevapGirisi2.Text = "";
                    YanlisCevap1_2.Text = "";
                    YanlisCevap2_2.Text = "";
                    YanlisCevap3_2.Text = "";
                    YanlisCevap4_2.Text = "";
                }
            }
        }
        public void yenile()
        {
            DataTable tablo = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Matematik", baglanti);

            da.Fill(tablo);
            DataGrid2.DataSource = tablo;
            SoruGirisi.Text = "";
            DogruCevapGirisi.Text = "";
            YanlisCevap1.Text = "";
            YanlisCevap2.Text = "";
            YanlisCevap3.Text = "";
            YanlisCevap4.Text = "";
            secilen.Text = "{x}";
            SoruGirisi2.Text = "";
            DogruCevapGirisi2.Text = "";
            YanlisCevap1_2.Text = "";
            YanlisCevap2_2.Text = "";
            YanlisCevap3_2.Text = "";
            YanlisCevap4_2.Text = "";
        }

        private void SecileniSil_Click(object sender, EventArgs e)
        {
            if (secilen.Text == "{x}")
            {
                MessageBox.Show("Önce işlem yapılacak soruyu belirlemelisiniz.", "Uyarı");
            }
            else
            {
                baglanti.Open();
                silinensoru = Convert.ToInt32(secilen.Text);
                silinendensonraki = silinensoru + 1;
                OleDbCommand sil = new OleDbCommand("DELETE * FROM Matematik WHERE SoruID=" + Convert.ToInt32(secilen.Text) + "", baglanti);
                OleDbDataReader read = sil.ExecuteReader();
                n = Convert.ToInt32(toplamSoruSayisi.Text);
                n = n - 1;
                toplamSoruSayisi.Text = Convert.ToString(n);
                OleDbCommand idduzenle;
                for (; silinensoru < Convert.ToInt32(toplamSoruSayisi.Text); silinensoru++)
                {
                    idduzenle = new OleDbCommand("UPDATE Matematik SET SoruID=" + silinensoru + " WHERE SoruID=" + silinendensonraki + "", baglanti);
                    idduzenle.ExecuteNonQuery();
                    silinendensonraki++;
                }
                yenile();
                baglanti.Close();
                MessageBox.Show("Soru başarıyla silindi.");
                lblSecilenBilgisi.Text = "Henüz seçilmedi";
            }
        }

        private void soruSayisiBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            if (SoruGirisi.Text == "")
            {
                MessageBox.Show("Soru girişi boş bırakılamaz.", "Hata");
            }
            else if (DogruCevapGirisi.Text == "")
            {
                MessageBox.Show("Doğru cevap girişi boş bırakılamaz.", "Hata");
            }
            else if (YanlisCevap1.Text == "" || YanlisCevap2.Text == "" || YanlisCevap3.Text == "" || YanlisCevap4.Text == "")
            {
                MessageBox.Show("4 adet yanlış cevap girilmelidir.", "Hata");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("INSERT INTO Matematik (Soru,Dogru,Yanlis1,Yanlis2,Yanlis3,Yanlis4,SoruID) VALUES(@soru,@dogru,@yanlis1,@yanlis2,@yanlis3,@yanlis4,@soruid)", baglanti);
                komut.Parameters.AddWithValue("@soru", SoruGirisi.Text);
                komut.Parameters.AddWithValue("@dogru", DogruCevapGirisi.Text);
                komut.Parameters.AddWithValue("@yanlis1", YanlisCevap1.Text);
                komut.Parameters.AddWithValue("@yanlis2", YanlisCevap2.Text);
                komut.Parameters.AddWithValue("@yanlis3", YanlisCevap3.Text);
                komut.Parameters.AddWithValue("@yanlis4", YanlisCevap4.Text);
                komut.Parameters.AddWithValue("@soruid", Convert.ToInt32(toplamSoruSayisi.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Soru ekleme işlemi başarılı.");
                yenile();
                n = Convert.ToInt32(toplamSoruSayisi.Text);
                n = n + 1;
                toplamSoruSayisi.Text = Convert.ToString(n);
                baglanti.Close();
            }
        }
    }
}
