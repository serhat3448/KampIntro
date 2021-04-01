using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 102936;
            musteri1.Adi = "Mark";
            musteri1.Soyadi = "Zuckerberg";
            musteri1.TelefonNo = 0545454545;

            Musteri musteri2 = new Musteri();
            musteri1.Id = 172936;
            musteri1.Adi = "Steve";
            musteri1.Soyadi = "Jobs";
            musteri1.TelefonNo = 054874545;

            Musteri musteri3 = new Musteri();
            musteri1.Id = 101136;
            musteri1.Adi = "Elon";
            musteri1.Soyadi = "Musk";
            musteri1.TelefonNo = 0548754545;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------------------Customer-Add---------------------------");
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            Console.WriteLine("---------------------Customer-Del---------------------------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            Console.WriteLine("---------------------Customer-List---------------------------");
            musteriManager.Listele(musteriler);
        }
    }
}
