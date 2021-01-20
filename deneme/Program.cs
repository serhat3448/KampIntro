using System;

namespace deneme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Kalem";
            urun1.Fiyati = 15;
            urun1.Renk = "Siyah";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Silgi";
            urun2.Fiyati = 20;
            urun2.Renk = "Beyaz";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Defter";
            urun3.Fiyati = 30;
            urun3.Renk = "Mavi";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }



        }
        
    }
}
