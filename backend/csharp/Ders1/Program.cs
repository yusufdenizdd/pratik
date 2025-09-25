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
        }
    }
}