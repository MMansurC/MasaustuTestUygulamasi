using System;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestUygulaması
{
    public partial class SinavEkranı : Form
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
        public SinavEkranı()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\TestUygulamasiDatabase.accdb");
        private void cevaprandomla()
        {
            for (int i = 0; i < cvpsec.Length; i++)
            {
                tut = rnd.Next(0, 5);
                if (i == 0)
                {
                    cvpsec[i] = tut;
                }
                for (int j = 0; j < i; j++)
                {
                    if (cvpsec[j] == tut)
                    {
                        i--;
                        break;
                    }
                    cvpsec[i] = tut;
                }
            }
        }
        private void sorugetir()
        {
            SimdikiSoru.Text = Convert.ToString(sorusec[sayi]);
            sayi++;
            OleDbCommand sorugetir = new OleDbCommand("SELECT Soru,Dogru,Yanlis1,Yanlis2,Yanlis3,Yanlis4 FROM Matematik WHERE SoruID=" + Convert.ToInt32(SimdikiSoru.Text) + "", baglanti);
            OleDbDataReader dr_ss;
            baglanti.Open();

            dr_ss = sorugetir.ExecuteReader();
            if (dr_ss.Read())
            {
                lblSoru.Text = dr_ss[0].ToString();
                if (cvpsec[0] == 0)
                {
                    lblA.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[0] == 1)
                {
                    lblA.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[0] == 2)
                {
                    lblA.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[0] == 3)
                {
                    lblA.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[0] == 4)
                {
                    lblA.Text = dr_ss[5].ToString();
                }

                if (cvpsec[1] == 0)
                {
                    lblB.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[1] == 1)
                {
                    lblB.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[1] == 2)
                {
                    lblB.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[1] == 3)
                {
                    lblB.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[1] == 4)
                {
                    lblB.Text = dr_ss[5].ToString();
                }

                if (cvpsec[2] == 0)
                {
                    lblC.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[2] == 1)
                {
                    lblC.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[2] == 2)
                {
                    lblC.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[2] == 3)
                {
                    lblC.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[2] == 4)
                {
                    lblC.Text = dr_ss[5].ToString();
                }

                if (cvpsec[3] == 0)
                {
                    lblD.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[3] == 1)
                {
                    lblD.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[3] == 2)
                {
                    lblD.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[3] == 3)
                {
                    lblD.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[3] == 4)
                {
                    lblD.Text = dr_ss[5].ToString();
                }

                if (cvpsec[4] == 0)
                {
                    lblE.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[4] == 1)
                {
                    lblE.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[4] == 2)
                {
                    lblE.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[4] == 3)
                {
                    lblE.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[4] == 4)
                {
                    lblE.Text = dr_ss[5].ToString();
                }
                seczBosBirak();
                baglanti.Close();
            }
        }
        private void sorukontrol()
        {
            if (checkBoxzBosBirak.Checked == true)
            {
                cevaprandomla();
            }
            else if (checkBoxA.Checked == true)
            {
                if (cvpsec[0] == 0)
                {
                    dogrusayac++;
                    cevaprandomla();
                }
                else
                {
                    yanlissayac++;
                    cevaprandomla();
                }
            }
            else if (checkBoxB.Checked == true)
            {
                if (cvpsec[1] == 0)
                {
                    dogrusayac++;
                    cevaprandomla();
                }
                else
                {
                    yanlissayac++;
                    cevaprandomla();
                }
            }
            else if (checkBoxC.Checked == true)
            {
                if (cvpsec[2] == 0)
                {
                    dogrusayac++;
                    cevaprandomla();
                }
                else
                {
                    yanlissayac++;
                    cevaprandomla();
                }
            }
            else if (checkBoxD.Checked == true)
            {
                if (cvpsec[3] == 0)
                {
                    dogrusayac++;
                    cevaprandomla();
                }
                else
                {
                    yanlissayac++;
                    cevaprandomla();
                }
            }
            else if (checkBoxE.Checked == true)
            {
                if (cvpsec[4] == 0)
                {
                    dogrusayac++;
                    cevaprandomla();
                }
                else
                {
                    yanlissayac++;
                    cevaprandomla();
                }
            }
            sorusayisi++;
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                lblSoruSayisi.Text = Convert.ToString(sorusayisi) + " / " + Convert.ToString(VizeSoruSayisi);
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                lblSoruSayisi.Text = Convert.ToString(sorusayisi) + " / " + Convert.ToString(FinalSoruSayisi);
            }
        }
        private int sorusayisi = 1;
        void secA()
        {
            checkBoxA.Checked = true;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxE.Checked = false;
            checkBoxzBosBirak.Checked = false;
            panelA.BackColor = Color.FromArgb(255, 150, 255, 150);
            panelB.BackColor = DefaultBackColor;
            panelC.BackColor = DefaultBackColor;
            panelD.BackColor = DefaultBackColor;
            panelE.BackColor = DefaultBackColor;
            panelzBosBirak.BackColor = DefaultBackColor;
        }
        void secB()
        {
            checkBoxA.Checked = false;
            checkBoxB.Checked = true;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxE.Checked = false;
            checkBoxzBosBirak.Checked = false;
            panelA.BackColor = DefaultBackColor;
            panelB.BackColor = Color.FromArgb(255, 150, 255, 150);
            panelC.BackColor = DefaultBackColor;
            panelD.BackColor = DefaultBackColor;
            panelE.BackColor = DefaultBackColor;
            panelzBosBirak.BackColor = DefaultBackColor;
        }
        void secC()
        {
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = true;
            checkBoxD.Checked = false;
            checkBoxE.Checked = false;
            checkBoxzBosBirak.Checked = false;
            panelA.BackColor = DefaultBackColor;
            panelB.BackColor = DefaultBackColor;
            panelC.BackColor = Color.FromArgb(255, 150, 255, 150);
            panelD.BackColor = DefaultBackColor;
            panelE.BackColor = DefaultBackColor;
            panelzBosBirak.BackColor = DefaultBackColor;
        }
        void secD()
        {
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = true;
            checkBoxE.Checked = false;
            checkBoxzBosBirak.Checked = false;
            panelA.BackColor = DefaultBackColor;
            panelB.BackColor = DefaultBackColor;
            panelC.BackColor = DefaultBackColor;
            panelD.BackColor = Color.FromArgb(255, 150, 255, 150);
            panelE.BackColor = DefaultBackColor;
            panelzBosBirak.BackColor = DefaultBackColor;
        }
        void secE()
        {
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxE.Checked = true;
            checkBoxzBosBirak.Checked = false;
            panelA.BackColor = DefaultBackColor;
            panelB.BackColor = DefaultBackColor;
            panelC.BackColor = DefaultBackColor;
            panelD.BackColor = DefaultBackColor;
            panelE.BackColor = Color.FromArgb(255, 150, 255, 150);
            panelzBosBirak.BackColor = DefaultBackColor;
        }
        void seczBosBirak()
        {
            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
            checkBoxE.Checked = false;
            checkBoxzBosBirak.Checked = true;
            panelA.BackColor = DefaultBackColor;
            panelB.BackColor = DefaultBackColor;
            panelC.BackColor = DefaultBackColor;
            panelD.BackColor = DefaultBackColor;
            panelE.BackColor = DefaultBackColor;
            panelzBosBirak.BackColor = Color.FromArgb(255, 245, 245, 110);
        }
        int toplamSoruSayisi, VizeSoruSayisi, FinalSoruSayisi, VizeSure, FinalSure;
        int[] cvpsec = new int[5];
        int[] sorusec = new int[25];
        Random rnd = new Random();
        int tut, dogrusayac = 0, yanlissayac = 0, sayi = 0;
        private int saniye, sureyarisi = 0;
        private string UcYBirDVize, UcYBirDFinal;

        private void SınavEkranı_Load(object sender, EventArgs e)
        {
            panel3.Size = new Size(900, 465);
            HazirsaBaslat.Size = new Size(896, 461);
            OgrenciNo.Text = OgrenciGiris.ogrno;
            OgrenciAdi.Text = OgrenciGiris.ogradi;
            seczBosBirak();
            baglanti.Open();
            OleDbCommand sorusayisiogren = new OleDbCommand("SELECT COUNT (Kimlik) FROM Matematik", baglanti);
            OleDbDataReader dr_ss = sorusayisiogren.ExecuteReader();
            if (dr_ss.Read())
            {
                fromDBSoruSayisi.Text = dr_ss[0].ToString();
                toplamSoruSayisi = Convert.ToInt32(fromDBSoruSayisi.Text);
            }
            cevaprandomla();
            baglanti.Close();
            baglanti.Open();
            OleDbCommand sinavsorusayisi = new OleDbCommand("SELECT VizeSoruSayisi,FinalSoruSayisi,VizeSaniye,FinalSaniye,UcYBirDVize,UcYBirDFinal FROM Sistem", baglanti);
            dr_ss = sinavsorusayisi.ExecuteReader();
            while (dr_ss.Read())
            {
                fromDBVizeSoruSayisi.Text = dr_ss[0].ToString();
                fromDBFinalSoruSayisi.Text = dr_ss[1].ToString();
                fromDBVizeSure.Text = dr_ss[2].ToString();
                fromDBFinalsure.Text = dr_ss[3].ToString();
                fromDB3y1dVize.Text = dr_ss[4].ToString();
                fromDB3y1dFinal.Text = dr_ss[5].ToString();
                VizeSoruSayisi = Convert.ToInt32(fromDBVizeSoruSayisi.Text);
                FinalSoruSayisi = Convert.ToInt32(fromDBFinalSoruSayisi.Text);
                VizeSure = Convert.ToInt32(fromDBVizeSure.Text);
                FinalSure = Convert.ToInt32(fromDBFinalsure.Text);
                UcYBirDVize = fromDB3y1dVize.Text;
                UcYBirDFinal = fromDB3y1dFinal.Text;
            }
            dr_ss.Close();
            baglanti.Close();
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                lblSoruSayisi.Text = Convert.ToString(sorusayisi) + " / " + Convert.ToString(VizeSoruSayisi);
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                lblSoruSayisi.Text = Convert.ToString(sorusayisi) + " / " + Convert.ToString(FinalSoruSayisi);
            }

            if (OgrenciAnaSayfa.vizetik == "1")
            {
                saniye = Convert.ToInt32(VizeSure);
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                saniye = Convert.ToInt32(FinalSure);
            }
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                bunifuCircleProgressbar1.MaxValue = saniye;
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                bunifuCircleProgressbar1.MaxValue = saniye;
            }
            else
            {
                MessageBox.Show("hata raporu 0011", "HATA");
            }

            if (OgrenciAnaSayfa.vizetik == "1")
            {
                for (int i = 0; i < Convert.ToInt32(VizeSoruSayisi); i++)
                {
                    tut = rnd.Next(0, toplamSoruSayisi);
                    if (i == 0)
                    {
                        sorusec[i] = tut;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        if (sorusec[j] == tut)
                        {
                            i--;
                            break;
                        }
                        sorusec[i] = tut;
                    }
                }
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                for (int i = 0; i < Convert.ToInt32(FinalSoruSayisi); i++)
                {
                    tut = rnd.Next(0, toplamSoruSayisi);
                    if (i == 0)
                    {
                        sorusec[i] = tut;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        if (sorusec[j] == tut)
                        {
                            i--;
                            break;
                        }
                        sorusec[i] = tut;
                    }
                }
            }

            SimdikiSoru.Text = Convert.ToString(sorusec[sayi]);
            sayi++;
            OleDbCommand sorugetir = new OleDbCommand("SELECT Soru,Dogru,Yanlis1,Yanlis2,Yanlis3,Yanlis4 FROM Matematik WHERE SoruID=" + Convert.ToInt32(SimdikiSoru.Text) + "", baglanti);
            baglanti.Open();
            dr_ss = sorugetir.ExecuteReader();
            if (dr_ss.Read())
            {
                lblSoru.Text = dr_ss[0].ToString();
                if (cvpsec[0] == 0)
                {
                    lblA.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[0] == 1)
                {
                    lblA.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[0] == 2)
                {
                    lblA.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[0] == 3)
                {
                    lblA.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[0] == 4)
                {
                    lblA.Text = dr_ss[5].ToString();
                }

                if (cvpsec[1] == 0)
                {
                    lblB.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[1] == 1)
                {
                    lblB.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[1] == 2)
                {
                    lblB.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[1] == 3)
                {
                    lblB.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[1] == 4)
                {
                    lblB.Text = dr_ss[5].ToString();
                }

                if (cvpsec[2] == 0)
                {
                    lblC.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[2] == 1)
                {
                    lblC.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[2] == 2)
                {
                    lblC.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[2] == 3)
                {
                    lblC.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[2] == 4)
                {
                    lblC.Text = dr_ss[5].ToString();
                }

                if (cvpsec[3] == 0)
                {
                    lblD.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[3] == 1)
                {
                    lblD.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[3] == 2)
                {
                    lblD.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[3] == 3)
                {
                    lblD.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[3] == 4)
                {
                    lblD.Text = dr_ss[5].ToString();
                }

                if (cvpsec[4] == 0)
                {
                    lblE.Text = dr_ss[1].ToString();
                }
                else if (cvpsec[4] == 1)
                {
                    lblE.Text = dr_ss[2].ToString();
                }
                else if (cvpsec[4] == 2)
                {
                    lblE.Text = dr_ss[3].ToString();
                }
                else if (cvpsec[4] == 3)
                {
                    lblE.Text = dr_ss[4].ToString();
                }
                else if (cvpsec[4] == 4)
                {
                    lblE.Text = dr_ss[5].ToString();
                }

            }
            baglanti.Close();



        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            secA();
        }

        private void kaliciA_Click(object sender, EventArgs e)
        {
            secA();
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            secB();
        }

        private void kaliciB_Click(object sender, EventArgs e)
        {
            secB();
        }

        private void HazirsaBaslat_Click(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.MaxValue;
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                KalanSure.Text = Convert.ToString(VizeSure);
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                KalanSure.Text = Convert.ToString(FinalSure);
            }
            else
            {
                MessageBox.Show("hata raporu 0010", "HATA");
            }
            timer1.Start();
            panel3.Visible = false;
            KaliciSoru.Visible = true;
            lblSoruSayisi.Visible = true;
            Cikis.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sureyarisi == 0)
            {
                sureyarisi = saniye / 2;
            }

            saniye--;
            bunifuCircleProgressbar1.Value = saniye;
            if (bunifuCircleProgressbar1.Value == sureyarisi)
            {
                bunifuCircleProgressbar1.ProgressColor = Color.Orange;
                KalanSure.ForeColor = Color.Orange;
            }
            if (saniye < 10)
            {
                bunifuCircleProgressbar1.ProgressColor = Color.Red;
                KalanSure.ForeColor = Color.Red;
            }
            if (saniye < 0)
            {
                saniye = 0;
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                MessageBox.Show("Süreniz doldu. Bu soru boş bırakılıp sonraki soruya geçiliyor.");
                seczBosBirak();
                sorukontrol();
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.MaxValue;
                if (OgrenciAnaSayfa.vizetik == "1")
                {
                    saniye = Convert.ToInt32(VizeSure);
                }
                else if (OgrenciAnaSayfa.finaltik == "1")
                {
                    saniye = Convert.ToInt32(FinalSure);
                }
                else
                {
                    MessageBox.Show("Hata Kodu 0012", "HATA");
                }
                bunifuCircleProgressbar1.ProgressColor = Color.SeaGreen;
                KalanSure.ForeColor = Color.SeaGreen;
                timer1.Start();
                if (OgrenciAnaSayfa.vizetik == "1")
                {
                    if (sayi + 1 == Convert.ToInt32(VizeSoruSayisi))
                    {
                        SonrakiSoru.Text = "Sınavı Bitir";
                    }
                    else if (sayi == Convert.ToInt32(VizeSoruSayisi))
                    {
                        float snc = dogrusayac * 100 / VizeSoruSayisi;
                        if (UcYBirDVize == "Evet")
                        {
                            snc = ((dogrusayac - ((yanlissayac - (yanlissayac % 3)) / 3)) * 100 / VizeSoruSayisi);
                        }
                        Sonuc.Text = Convert.ToString(snc);
                        OleDbCommand vizenotgirisi = new OleDbCommand("UPDATE Ogrenci SET Vize='" + Sonuc.Text + "',VizeGiris='Girildi' WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
                        baglanti.Open();
                        vizenotgirisi.ExecuteNonQuery();
                        timer1.Stop();
                        this.Hide();

                        baglanti.Close();
                    }
                }
                else if (OgrenciAnaSayfa.finaltik == "1")
                {
                    if (sayi + 1 == Convert.ToInt32(FinalSoruSayisi))
                    {
                        SonrakiSoru.Text = "Sınavı Bitir";
                    }
                    else if (sayi == Convert.ToInt32(FinalSoruSayisi))
                    {
                        float snc = dogrusayac * 100 / FinalSoruSayisi;
                        if (UcYBirDFinal == "Evet")
                        {
                            snc = ((dogrusayac - ((yanlissayac - (yanlissayac % 3)) / 3)) * 100 / FinalSoruSayisi);
                        }
                        Sonuc.Text = Convert.ToString(snc);
                        OleDbCommand finalnotgirisi = new OleDbCommand("UPDATE Ogrenci SET Final='" + Sonuc.Text + "',FinalGiris='Girildi' WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
                        baglanti.Open();
                        finalnotgirisi.ExecuteNonQuery();
                        timer1.Stop();
                        this.Hide();

                        baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hata Kodu 0000", "HATA");
                }
                sorugetir();
            }
            KalanSure.Text = Convert.ToString(saniye);
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            secC();
        }

        private void kaliciC_Click(object sender, EventArgs e)
        {
            secC();
        }

        private void SonrakiSoru_Click(object sender, EventArgs e)
        {
            sorukontrol();
            bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.MaxValue;
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                saniye = Convert.ToInt32(VizeSure);
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                saniye = Convert.ToInt32(FinalSure);
            }
            else
            {
                MessageBox.Show("Hata Kodu 0013", "HATA");
            }
            bunifuCircleProgressbar1.ProgressColor = Color.SeaGreen;
            KalanSure.ForeColor = Color.SeaGreen;
            timer1.Start();
            if (OgrenciAnaSayfa.vizetik == "1")
            {
                if (sayi + 1 == Convert.ToInt32(VizeSoruSayisi))
                {
                    SonrakiSoru.Text = "Sınavı Bitir";
                }
                else if (sayi == Convert.ToInt32(VizeSoruSayisi))
                {
                    float snc = dogrusayac * 100 / VizeSoruSayisi;
                    if (UcYBirDVize == "Evet")
                    {
                        snc = ((dogrusayac - ((yanlissayac - (yanlissayac % 3)) / 3)) * 100 / VizeSoruSayisi);
                    }
                    Sonuc.Text = Convert.ToString(snc);
                    OleDbCommand vizenotgirisi = new OleDbCommand("UPDATE Ogrenci SET Vize='" + Sonuc.Text + "',VizeGiris='Girildi' WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
                    baglanti.Open();
                    vizenotgirisi.ExecuteNonQuery();
                    timer1.Stop();
                    this.Hide();

                    baglanti.Close();
                }
            }
            else if (OgrenciAnaSayfa.finaltik == "1")
            {
                if (sayi + 1 == Convert.ToInt32(FinalSoruSayisi))
                {
                    SonrakiSoru.Text = "Sınavı Bitir";
                }
                else if (sayi == Convert.ToInt32(FinalSoruSayisi))
                {
                    float snc = dogrusayac * 100 / FinalSoruSayisi;
                    if (UcYBirDFinal == "Evet")
                    {
                        snc = ((dogrusayac - ((yanlissayac - (yanlissayac % 3)) / 3)) * 100 / FinalSoruSayisi);
                    }
                    Sonuc.Text = Convert.ToString(snc);
                    OleDbCommand finalnotgirisi = new OleDbCommand("UPDATE Ogrenci SET Final='" + Sonuc.Text + "',FinalGiris='Girildi' WHERE OgrenciNo='" + OgrenciNo.Text + "'", baglanti);
                    baglanti.Open();
                    finalnotgirisi.ExecuteNonQuery();
                    timer1.Stop();
                    this.Hide();

                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata Kodu 0000", "HATA");
            }
            sorugetir();
        }


        private void lblD_Click(object sender, EventArgs e)
        {
            secD();
        }

        private void kaliciD_Click(object sender, EventArgs e)
        {
            secD();
        }

        private void lblE_Click(object sender, EventArgs e)
        {
            secE();
        }

        private void kaliciE_Click(object sender, EventArgs e)
        {
            secE();
        }

        private void lblzBosBirak_Click(object sender, EventArgs e)
        {
            seczBosBirak();
        }
    }
}
