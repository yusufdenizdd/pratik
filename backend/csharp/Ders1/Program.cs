//using System; artık gerek yok yeni cs

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double oran = 32.5;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("giriş yapıldı");

            }
            else
            {
                Console.WriteLine("giriş yapılmadı");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }

            string[] kurslar = new string[] {
                "Yazılım Geliştiricisi Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "java",
                "c#"
            };

            // string[] kurslar = kurslariGetir(); gerçek hayatta böyle oluyor

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 0;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 20;

            Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);

            Kurs[] kurslar2 = new Kurs[] {
                kurs1, kurs2, kurs3
            };

            foreach (Kurs kurs in kurslar2)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }



    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }




}