using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuzTanima.Temel
{
    class Kisi : IComparable<Kisi>
    {
        public int Id;
        public string Isim;

        private string klasor;
        public string Klasor
        {
            get
            {
                return klasor;
            }
        }

        public string Taniyici
        {
            get
            {
                return Path.Combine(new string[]
                {
                    klasor, "taniyici.dat"
                });
            }
        }

        private List<string> fotograflar;
        public string[] Fotograflar
        {
            get
            {
                string[] cikti = new string[fotograflar.Count];

                for (var i = 0; i < cikti.Length; i++)
                {
                    cikti[i] = Path.GetFileNameWithoutExtension(fotograflar[i]);
                }

                return cikti;
            }
        }

        private static string[] imajUzantilari = new string[]
            {
                ".png", ".bmp", ".jpg", ".jpeg", ".pgm"
            };

        public Kisi(int Id, string Isim)
        {
            this.Id = Id;
            this.Isim = Isim;

            this.klasor = Path.Combine(new string[]
            {
                Ayarlar.CalismaKlasoru, "kisiler", "kisi_" + Id
            });

            KlasorTara();
        }

        public string FotografGetir(int index)
        {
            return fotograflar[index];
        }

        public void FotografSil(int index)
        {
            File.Delete(FotografGetir(index));
            KlasorTara();
        }

        public void KlasorTara()
        {
            if (!Directory.Exists(this.klasor))
            {
                Directory.CreateDirectory(klasor);
            }

            this.fotograflar = new List<string>();

            string[] klasorIcerigi = Directory.GetFiles(klasor);
            for (var i = 0; i < klasorIcerigi.Length; i++)
            {
                if (Array.BinarySearch(imajUzantilari, Path.GetExtension(klasorIcerigi[i]).ToLower()) == -1)
                {
                    continue;
                }

                this.fotograflar.Add(klasorIcerigi[i]);
            }
        }

        public int CompareTo(Kisi other)
        {
            return Isim.CompareTo(other.Isim);
        }

        public override string ToString()
        {
            return String.Join(",", new string[] { Id.ToString(), Isim });
        }
    }
}
