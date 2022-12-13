using System;

namespace müşteritakip
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adı = "mustafa";
            musteri1.soyadı = "turan";
            musteri1.Tc = "345678976786";
            musteri1.Id = 345;

            Musteri musteri2 = new Musteri ();
            musteri2.Adı = "ali";
            musteri2.soyadı = "kurt";
            musteri2.Tc = "8765434567";
            musteri2.Id = 276;

            Musteri musteri3 = new Musteri();
            musteri3.Adı = "murat";
            musteri3.soyadı = "erol";
            musteri3.Tc = "345432456731";
            musteri3.Id = 389;

            Musteri musteri4 = new Musteri();
            musteri4.Adı = "bedirhan";
            musteri4.soyadı = "dinç";
            musteri4.Tc = "3456654323456";
            musteri4.Id = 179;

            Musteri[] musteris = new Musteri[4] { musteri1, musteri2, musteri3, musteri4 };
            Console.WriteLine("no:");
            int x = Convert.ToInt32(Console.ReadLine());
            MusterıManager musteriler = new MusterıManager();

            musteriler.ekle(musteris[x]);

            //foreach (Musteri musteri in musteris)
            //{
            //    musteriler.ekle(musteri);
            //}



            //musteriler.ekle(musteri1);
            //musteriler.listele(musteri1);
            //musteriler.sil(musteri1);

            //musteriler.listele(musteri1);
            //Console.WriteLine("...................");
            //musteriler.listele(musteri2);
            //Console.WriteLine("..................;");
            //musteriler.listele(musteri3);
            //Console.WriteLine("....................");
            //musteriler.listele(musteri4);
            //Console.WriteLine(".....................");

            //musteriler.ekle(musteri1);
            //Console.WriteLine("..................");
            //musteriler.ekle(musteri2);
            //Console.WriteLine("......................");
            //musteriler.ekle(musteri3);
            //Console.WriteLine(".......................");
            //musteriler.ekle(musteri4);
            //Console.WriteLine("......................");

            //musteriler.sil(musteri1);
            //Console.WriteLine(".......................");
            //musteriler.sil(musteri2);
            //Console.WriteLine("....................");
            //musteriler.sil(musteri3);
            //Console.WriteLine("......................");
            //musteriler.sil(musteri4);
            //Console.WriteLine(".....................");


            //MusterıManager manager = new MusterıManager();


            //while (true)
            //{
            //    int islem = 0;
            //    Console.WriteLine("işlem seçiniz:");
            //    Console.WriteLine("1 Ekle:");
            //    Console.WriteLine("2 Listele:");
            //    Console.WriteLine("3 Sil ");

            //    islem = Convert.ToInt32(Console.ReadLine());
            //    switch (islem)
            //    {
            //        case 1:
            //            Musteri yenimusteri = new Musteri();
            //            Console.WriteLine("Müşteri Adı:");
            //            yenimusteri.Adı = Console.ReadLine();
            //            Console.WriteLine("Müşteri Soyadı:");
            //            yenimusteri.soyadı = Console.ReadLine();
            //            Console.WriteLine("Müşteri Tc:");
            //            yenimusteri.Tc = Console.ReadLine();
            //            Console.WriteLine("Müşteri Id:");
            //            yenimusteri.Id = Convert.ToInt32(Console.ReadLine());

            //            manager.ekle(yenimusteri);


            //            break;
            //        case 2:

            //            break;
            //        case 3:

            //            break;
            //    }
            //}


        }
               
           



           
        }
    }

