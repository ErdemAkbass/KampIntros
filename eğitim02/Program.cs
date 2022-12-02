using System;

namespace eğitim02
{
    class Program
    {
        static void Main(string[] args)
        { 
       
    
        product urun1 = new product();
        urun1.urunadı = "sweatshirt";
                urun1.urunfiyat = 200;
                urun1.urunrenk = "lacivert";
                urun1.urunıd = 287634;

                product urun2 = new product();
        urun2.urunadı = "ayakkabı";
                urun2.urunfiyat = 450;
                urun2.urunrenk = "siyah";
                urun2.urunıd = 376289;

                product urun3 = new product();
        urun3.urunadı = "telefon";
                urun3.urunfiyat = 15000;
                urun3.urunrenk = "siyah";
                urun3.urunıd = 938476;

                product urun4 = new product();
        urun4.urunadı = "saat";
                urun4.urunfiyat = 1000;
                urun4.urunrenk = "beyaz";
                urun4.urunıd = 917982;

                product[] urunler = new product[] { urun1, urun2, urun3, urun4 };

                for (int i = 0; i<urunler.Length; i++)
                {
                    Console.WriteLine("Ürun adı:" + urunler[i].urunadı);
                    Console.WriteLine("Ürün Fiyat:" + urunler[i].urunfiyat);
                    Console.WriteLine("Ürün Renk:" + urunler[i].urunrenk);
                    Console.WriteLine("Ürün Id:" + urunler[i].urunıd+"\n");
                }
            foreach (var product in urunler)
            {
                Console.WriteLine("Ürün Adı:" + urun1.urunadı + "Ürün Fiyatı:" + urun2.urunfiyat + "Ürün Rengi:" + urun3.urunrenk + "Ürün Id" + urun4.urunıd + "\n");
            }
}

class product
{
    public string urunadı;
    public int urunfiyat;
    public string urunrenk;
    public int urunıd;
}
    }
}
