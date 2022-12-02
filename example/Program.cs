using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {


            menu menu1 = new menu();
            menu1.Adı = "öğrenci menü";
            menu1.içindekiler = "pizza,soğan halkası,nugget,1L kola";
            menu1.fiyat=90;
            menu1.ıd = 1;
            

            menu menu2 = new menu();
            menu2.Adı = "çılgın menü";
            menu2.içindekiler = "döner,patates,nugget,kutu icetea";
            menu2.fiyat = 100;
            menu2.ıd = 2;

            menu menu3 = new menu();
            menu3.Adı = "special menü";
            menu3.içindekiler = "hamburger,patates,soğan halkası,kutu kola";
            menu3.fiyat = 110;
            menu3.ıd = 3;

            menu menu4 = new menu();
            menu4.Adı = "aile menü";
            menu4.içindekiler = "büyük boy pizza,patates,soğan halkası,nugget,1lt içecek";
            menu4.fiyat = 180;
            menu4.ıd = 4;

            menu[] menuler = new menu[] { menu1, menu2, menu3, menu4 };

            for (int i = 0; i < menuler.Length; i++)
            {
                Console.WriteLine("Ürün Adı:"+menuler[i].Adı);
                Console.WriteLine("Ürünün içindekileri:" + menuler[i].içindekiler);
                Console.WriteLine("Ürün Fiyatı:" + menuler[i].fiyat);
                Console.WriteLine("Ürün ID:" + menuler[i].ıd+"\n");
            }
            foreach (menu menu in menuler)
            {
                Console.WriteLine("Ürün Adı:" + menu.Adı + "\n" + "Ürün İçindekileri" + menu.içindekiler + "\n"+"Ürün Fiyatı:"+menu.fiyat+"\n"+"Ürün Id"+menu.ıd+"\n");
            }
        }
        class menu
        {
            public string Adı;
            public string içindekiler;
            public int fiyat;
            public int ıd;
        }
    }
}
