using MyDictionary;
using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
          

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Serhat");
            dictionary.Add(105, "Serkan");
            dictionary.Add(88, "Selda");

            dictionary.Listele();
        }
    }
}
