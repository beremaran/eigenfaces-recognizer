using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuzTanima.Temel
{
    class KisiYoneticisi
    {

        private List<Kisi> kisiler;
        public string[] KisiIsimleri
        {
            get
            {
                string[] isimler = new string[kisiler.Count];
                for (var i = 0; i < isimler.Length; i++)
                {
                    isimler[i] = kisiler[i].Isim;
                }

                return isimler;
            }
        }

        private string KisiListesi
        {
            get
            {
                return Path.Combine(new string[]
                {
                    Ayarlar.CalismaKlasoru, "Kisiler.csv"
                });
            }
        }

        public KisiYoneticisi()
        {
            kisiler = new List<Kisi>();
            kisileriYukle();
        }

        public Kisi KisiGetir(string Isim)
        {
            for (var i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Isim.Equals(Isim))
                {
                    return kisiler[i];
                }
            }

            return null;
        }

        public Kisi KisiGetir(int Id)
        {
            for (var i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Id == Id)
                {
                    return kisiler[i];
                }
            }

            return null;
        }

        public void KisiOlustur(string Isim)
        {
            Ayarlar.SonId = Ayarlar.SonId + 1;
            Kisi yeniKisi = new Kisi(Ayarlar.SonId, Isim);
            Ayarlar.KlasorOlustur(yeniKisi);

            kisiler.Add(yeniKisi);
            kisileriKaydet();
        }

        public void KisiSil(string Isim)
        {
            Kisi kisi = KisiGetir(Isim);
            kisiler.Remove(kisi);

            string[] dosyalar = Directory.GetFiles(kisi.Klasor);
            for (var i = 0; i < dosyalar.Length; i++)
            {
                File.Delete(dosyalar[i]);
            }

            Directory.Delete(kisi.Klasor);
            kisileriKaydet();
        }

        public void FotografEkle(string Isim, string dosya)
        {
            Kisi kisi = KisiGetir(Isim);
            string dosyaIsmi = Path.GetFileName(dosya);
            string hedef = Path.Combine(new string[]
            {
                        kisi.Klasor, dosyaIsmi
            });

            File.Copy(dosya, hedef);
            kisi.KlasorTara();
        }

        private void kisileriYukle()
        {
            if (!File.Exists(KisiListesi))
            {
                File.CreateText(KisiListesi).Close();
            }

            StreamReader sr = new StreamReader(KisiListesi);

            while (!sr.EndOfStream)
            {
                // id,isim
                string[] satir = sr.ReadLine().Trim().Split(',');
                Kisi kisi = new Kisi(int.Parse(satir[0]), satir[1]);
                kisiler.Add(kisi);
            }

            sr.Close();
        }

        private void kisileriKaydet()
        {
            if (!File.Exists(KisiListesi))
            {
                File.CreateText(KisiListesi).Close();
            }

            StreamWriter sw = new StreamWriter(KisiListesi);

            for (var i = 0; i < kisiler.Count; i++)
            {
                sw.WriteLine(kisiler[i].ToString());
            }

            sw.Close();
        }

    }
}
