namespace Metotlar
{
    class CartManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(product.Adi + " ürünü sepete eklendi");
        }
    }
    class Product
    {

        public int Id { get; set; }
        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }

    }

    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1 + " + " + sayi2 + " = " + toplam);
        }
    }
}