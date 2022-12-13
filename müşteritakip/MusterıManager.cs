using System;
using System.Collections.Generic;
using System.Text;

namespace müşteritakip
{
    class MusterıManager
    {
        public void ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + " Müşteri Eklendi");
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı:" + musteri.Adı);
            Console.WriteLine("Müşteri Soyadı:" + musteri.soyadı);
            Console.WriteLine("Müşteri Tc:" + musteri.Tc);
            Console.WriteLine("Müşteri Id:" + musteri.Id); 
        }
        public void sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + "Müşteri Silindi");
        }

           
        
        
        //public List<Musteri> Musteriler = new List<Musteri>();
    //    public void ekle(Musteri musteri)
    //    {
    //        Musteriler.Add(musteri);
    //        Console.WriteLine(musteri.Adı + "Müşteri Eklendi");
    //    }
    //    public void listele()
    //    {
    //        foreach (var musteri in Musteriler)
    //        {
    //            Console.WriteLine("Müşteri T.c:" + musteri.Tc);
    //            Console.WriteLine("Müşteri Adı:" + musteri.Adı);
    //            Console.WriteLine("Müşteri Soyadı:" + musteri.soyadı);
    //            Console.WriteLine("Müşteri Id:" + musteri.Id);
    //        }
    //    }
    //    public void sil(Musteri musteri)
    //    {
    //        Musteriler.Remove(musteri);
    //        Console.WriteLine(musteri.Adı + "Müşteri Silindi");
    //    }
    //
    }
}
