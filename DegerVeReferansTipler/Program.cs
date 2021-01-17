using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            int[] sayilar3 = new int[] { 1, 2, 3 };
            sayilar3 = sayilar1;
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999


            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayilar3[0]);

            // int, decimal, float, double, bool = değer tip
            // array, class, interface = referans tip
            // İlk kısımda sayi1 e sayi2'nin değerini aradık.
            // İkinci kısımda sayilar1 array'ine sayilar2 array'inin referansını verdik.
            // sayilar1 array'ine dedik ki senin referansın bundan sonra sayilar2 array'inin referansı. Bellekteki yeri işaret ettik.
            // Dolayısı ile bellekte o kısım değişince bu durumdan etkileniyor.
            // Değer tipler belleteki alanlardan (Stack ve Heap) stack de tutulur.
            // Referans tipler new' e kadar Stackde newlediğimiz zaman da Heap de yer oluşturur.
            // "Yazılım Geliştirici Yetiştime Kampı 3. Gün C# Temelleri 2" adlı videonun son 20 dakikasına bakabilirsinç
        }
    }
}
