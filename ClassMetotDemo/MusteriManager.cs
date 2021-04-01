using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " eklendi.");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " güncellendi.");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " silindi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
            }
            
        }
    }
}