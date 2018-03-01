using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YuzTanima.Temel
{
    class YuzTaniyici
    {

        private const int YENI_BOYUT = 80;
        private const int OZELLIK_SAYISI = 80;

        private IIlerlemeBildirimi ilerlemeBildirimi;

        private KisiYoneticisi kisiYoneticisi;
        private Dictionary<int, List<Image<Gray, Byte>>> imajlar;

        private FaceRecognizer taniyici;

        private static CascadeClassifier haar;

        private string taniyiciYol = Path.Combine(new string[]
            {
                Ayarlar.CalismaKlasoru, "taniyici.eigen"
            });

        public YuzTaniyici(KisiYoneticisi kisiYoneticisi, IIlerlemeBildirimi ilerlemeBildirimi)
        {
            this.kisiYoneticisi = kisiYoneticisi;
            imajlar = new Dictionary<int, List<Image<Gray, byte>>>();

            this.ilerlemeBildirimi = ilerlemeBildirimi;
            if (this.ilerlemeBildirimi != null)
            {
                this.ilerlemeBildirimi.ayarla(5);
            }

            this.ilerlemeBildirimi.ilerle("İmajlar hafızaya yükleniyor ..");
            imajlariYukle();
            this.ilerlemeBildirimi.ilerle("İmajlar önişlemeden geçiriliyor ..");
            onisleme();
            this.ilerlemeBildirimi.ilerle("Eigenfaces eğitiliyor ..");
            egitim();
            this.ilerlemeBildirimi.ilerle("Eğitim Tamamlandı.");
            this.ilerlemeBildirimi.ilerle("İşlem tamamlandı. Tanımlama aşamasına devam edebilirsiniz.");
        }

        public Kisi Tani(Image<Gray, byte> imaj)
        {
            FaceRecognizer.PredictionResult pr = taniyici.Predict(imaj);
            var tahmin = pr.Label;

            return kisiYoneticisi.KisiGetir(tahmin);
        }

        public Image<Gray, byte> YerindeTani(Image<Gray, byte> imaj)
        {
            if (haar == null)
            {
                haar = new CascadeClassifier(Path.Combine(new string[] { Ayarlar.CalismaKlasoru, "frontalface_haar.xml" }));
            }

            int k = 800 / imaj.Height;
            imaj = imaj.Resize(k, Emgu.CV.CvEnum.Inter.Linear);

            Image<Gray, byte> imaj2 = imaj.Clone();
            CvInvoke.CLAHE(imaj, 40, new Size(3, 3), imaj2);

            var faces = haar.DetectMultiScale(imaj2);
            if (faces.Length > 0)
            {
                for (var i = 0; i < faces.Length; i++)
                {
                    var face = faces[i];
                    var rect = new Rectangle(face.X, face.Y, face.Width, face.Height);
                    var _imaj = imaj.GetSubRect(rect);
                    _imaj = _imaj.Resize(YENI_BOYUT, YENI_BOYUT, Emgu.CV.CvEnum.Inter.Linear);

                    Kisi tespit = Tani(_imaj);

                    if (tespit != null)
                    {
                        Point yaziKonum = new Point(rect.Location.X, rect.Location.Y - 100);
                        CvInvoke.PutText(imaj, tespit.Isim, rect.Location, Emgu.CV.CvEnum.FontFace.HersheyPlain, 3, new MCvScalar(255), 2);
                        imaj.Draw(rect, new Gray(255), 2);
                    }
                }
            }

            return imaj;
        }

        private void ilerlemeBildir(string mesaj)
        {
            if (ilerlemeBildirimi != null)
            {
                ilerlemeBildirimi.ilerle(mesaj);
            }
        }

        private void egitim()
        {
            taniyici = new EigenFaceRecognizer(OZELLIK_SAYISI, double.PositiveInfinity);

            List<int> etiketler = new List<int>();
            List<Image<Gray, byte>> tumImajlar = new List<Image<Gray, byte>>();

            var idler = imajlar.Keys.ToArray();
            for (var i = 0; i < idler.Length; i++)
            {
                List<Image<Gray, byte>> kImajlar = imajlar[idler[i]];

                tumImajlar.AddRange(kImajlar);
                for (var j = 0; j < kImajlar.Count; j++)
                {
                    etiketler.Add(idler[i]);
                }
            }

            taniyici.Train(tumImajlar.ToArray(), etiketler.ToArray());

            if (!File.Exists(taniyiciYol))
            {
                File.Create(taniyiciYol).Close();
            }
        }

        private Image<Gray, byte>[] kisiImajlariGetir(int id)
        {
            return imajlar[id].ToArray();
        }

        private void onisleme()
        {
            var idler = imajlar.Keys.ToArray();
            for (var i = 0; i < idler.Length; i++)
            {
                List<Image<Gray, byte>> listIm = imajlar[idler[i]];

                for (var j = 0; j < listIm.Count; j++)
                {
                    listIm[j] = YuzTaniyici.onisleme(listIm[j]);
                }
            }
        }

        public static Image<Gray, byte> onisleme(Image<Gray, byte> imaj, bool yalnizcaYuzuKirp = false)
        {
            if (haar == null)
            {
                haar = new CascadeClassifier(Path.Combine(new string[] { Ayarlar.CalismaKlasoru, "frontalface_haar.xml" }));
            }

            if (!yalnizcaYuzuKirp)
                CvInvoke.CLAHE(imaj, 40, new Size(3, 3), imaj);

            var face = haar.DetectMultiScale(imaj);
            if (face.Length > 0)
            {
                imaj = imaj.GetSubRect(new Rectangle(face[0].X, face[0].Y, face[0].Width, face[0].Height));
            }

            if (!yalnizcaYuzuKirp)
                imaj = imaj.Resize(YENI_BOYUT, YENI_BOYUT, Emgu.CV.CvEnum.Inter.Linear);
            return imaj;
        }

        public static Image<Gray, byte> onisleme(string imajYolu, bool yalnizcaYuzuKirp = false)
        {
            Image<Gray, byte> im = new Image<Rgb, byte>(imajYolu).Convert<Gray, byte>();
            return onisleme(im, yalnizcaYuzuKirp);
        }

        private void imajlariYukle()
        {
            var isimler = kisiYoneticisi.KisiIsimleri;
            for (var i = 0; i < isimler.Length; i++)
            {
                Kisi kisi = kisiYoneticisi.KisiGetir(isimler[i]);
                List<Image<Gray, Byte>> kisiImaj = new List<Image<Gray, byte>>();

                string[] fotograflar = kisi.Fotograflar;
                for (var j = 0; j < fotograflar.Length; j++)
                {
                    var renkli = new Image<Rgb, byte>(kisi.FotografGetir(j));
                    var gri = renkli.Convert<Gray, byte>().Resize(YENI_BOYUT, YENI_BOYUT, Emgu.CV.CvEnum.Inter.Linear);
                    kisiImaj.Add(gri);
                    renkli.Dispose();
                }

                imajlar[kisi.Id] = kisiImaj;
            }
        }
    }
}
