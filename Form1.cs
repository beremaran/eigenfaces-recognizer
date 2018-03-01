using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuzTanima.Properties;
using YuzTanima.Temel;

namespace YuzTanima
{
    public partial class Form1 : Form, IIlerlemeBildirimi
    {

        private VideoCapture kamera;

        private Kisi GecerliKisi;
        private KisiYoneticisi kisiYoneticisi;

        private List<string> egitimLoglar;

        private int egitimAdimi = 10;
        private YuzTaniyici yuzTaniyici;
        private Image<Gray, byte> tanilanacakImaj;

        private bool canliKamera = false;

        public Form1()
        {
            InitializeComponent();

            Ayarlar.Yukle();
            kisiYoneticisi = new KisiYoneticisi();
            GecerliKisi = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listKisiler.DataSource = kisiYoneticisi.KisiIsimleri;
            btnFotografEkle.Enabled = false;
            btnFotografSil.Enabled = false;
            btnKisiSil.Enabled = false;
            txtDosyaAdi.Text = "";
        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            YeniKisiForm yeniKisiForm = new YeniKisiForm();

            if (yeniKisiForm.ShowDialog() == DialogResult.OK)
            {
                kisiYoneticisi.KisiOlustur((yeniKisiForm.Controls["textBox1"] as TextBox).Text.Trim());
                listKisiler.DataSource = kisiYoneticisi.KisiIsimleri;
            }
        }

        private void listKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            GecerliKisi = kisiYoneticisi.KisiGetir(listKisiler.SelectedItem.ToString());

            if (GecerliKisi != null)
            {
                listKisiFotograflar.DataSource = GecerliKisi.Fotograflar;
                btnKisiSil.Enabled = true;
                btnFotografEkle.Enabled = true;
            }
            else
            {
                picOnizleme.Image = null;
                btnFotografEkle.Enabled = false;
                btnFotografSil.Enabled = false;
                btnKisiSil.Enabled = false;
                listKisiFotograflar.DataSource = null;
                txtDosyaAdi.Text = "";
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            kisiYoneticisi.KisiSil(listKisiler.SelectedItem.ToString());
            listKisiler.DataSource = kisiYoneticisi.KisiIsimleri;
            if (kisiYoneticisi.KisiIsimleri.Length == 0)
            {
                listKisiler.DataSource = new string[] { "" };
                listKisiler.SelectedIndex = 0;
            }
        }

        private void btnFotografEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            d.Filter = "İmaj Dosyaları (*.bmp, *.jpg, *.jpeg, *.png *.pgm) | *.bmp; *.jpg; *.jpeg; *.png; *.pgm;";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string yeniDosya = d.FileName;
                kisiYoneticisi.FotografEkle(GecerliKisi.Isim, yeniDosya);
                listKisiFotograflar.DataSource = GecerliKisi.Fotograflar;
            }
        }

        private void listKisiFotograflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GecerliKisi != null)
            {
                string tamYol = GecerliKisi.FotografGetir(listKisiFotograflar.SelectedIndex);
                picOnizleme.Image = YuzTaniyici.onisleme(tamYol, true).ToBitmap();
                btnFotografSil.Enabled = true;
                txtDosyaAdi.Text = listKisiFotograflar.SelectedItem.ToString();
            }
            else
            {
                picOnizleme.Image = null;
                btnFotografSil.Enabled = false;
                txtDosyaAdi.Text = "";
            }
        }

        private void btnFotografSil_Click(object sender, EventArgs e)
        {
            GecerliKisi.FotografSil(listKisiFotograflar.SelectedIndex);
            listKisiFotograflar.DataSource = GecerliKisi.Fotograflar;
        }

        private void btnEgitimBaslat_Click(object sender, EventArgs e)
        {
            egitimLoglar = new List<string>();
            txtEgitimLog.Clear();
            egitimIlerlemeGuncelle(0);

            egitimLogEkle("Eğitim başlıyor ..");

            new Thread(() =>
            {
                yuzTaniyici = new YuzTaniyici(kisiYoneticisi, this);
            }).Start();
        }

        private void egitimLogEkle(string mesaj)
        {
            egitimLoglar.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + mesaj);
            txtEgitimLog.Invoke((MethodInvoker)(() =>
            {
                txtEgitimLog.Lines = egitimLoglar.ToArray();
            }));
        }

        private void egitimIlerlemeGuncelle(int deger)
        {
            progressEgitim.Invoke((MethodInvoker)(() =>
               {
                   if (deger > 100)
                       deger = 100;

                   progressEgitim.Value = deger;
               }));

            txtProgress.Invoke((MethodInvoker)(() =>
                {
                    txtProgress.Text = deger + "%";
                }));
        }

        public void ayarla(int toplamAdimlar)
        {
            egitimIlerlemeGuncelle(0);
            egitimAdimi = (int)Math.Round(100.0 / toplamAdimlar);
        }

        public void ilerle(string mesaj)
        {
            egitimIlerlemeGuncelle(progressEgitim.Value + egitimAdimi);
            egitimLogEkle(mesaj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canliKamera = false;
            timer1.Enabled = canliKamera;
            if (kamera != null)
                kamera.Stop();

            OpenFileDialog d = new OpenFileDialog();

            d.Filter = "İmaj Dosyaları (*.bmp, *.jpg, *.jpeg, *.png *.pgm) | *.bmp; *.jpg; *.jpeg; *.png; *.pgm;";

            if (d.ShowDialog() == DialogResult.OK)
            {
                Image<Gray, byte> kare = new Image<Gray, byte>(d.FileName);
                picHamImaj.Image = yuzTaniyici.YerindeTani(kare).ToBitmap();
            }
        }

        private void btnKameradanYukle_Click(object sender, EventArgs e)
        {
            canliKamera = false;
            timer1.Enabled = canliKamera;

            // BUNLARI YUZTANIMA.ONISLEME YE AL
            if (kamera == null)
            {
                kamera = new VideoCapture();
            }

            Image<Gray, byte> kare = kamera.QueryFrame().ToImage<Gray, byte>();
            picHamImaj.Image = yuzTaniyici.YerindeTani(kare).ToBitmap();

            kamera.Stop();
            kamera.Dispose();
            kamera = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kamera == null)
            {
                kamera = new VideoCapture(0);
            }

            if (canliKamera)
            {
                Image<Gray, byte> kare = kamera.QueryFrame().ToImage<Gray, byte>();
                picHamImaj.Image = yuzTaniyici.YerindeTani(kare).ToBitmap();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            canliKamera = !canliKamera;
            timer1.Enabled = canliKamera;

            if (!canliKamera)
            {
                button1.Text = "Kameradan Canlı";
                kamera.Stop();
                kamera.Dispose();
                kamera = null;
            }
            else
            {
                button1.Text = "DURDUR";
            }
        }
    }
}
