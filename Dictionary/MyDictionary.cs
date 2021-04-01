using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        (Key, Value)[] keyValues;

        public MyDictionary()
        {
            keyValues = new (Key, Value)[0];
        }

        public void Add(Key No, Value Name)
        {
            (Key, Value)[] tempArray = keyValues;

            keyValues = new (Key, Value)[keyValues.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                keyValues[i] = tempArray[i];
            }

            keyValues[keyValues.Length - 1] = (No, Name);
        }


        public void Listele()
        {
            for (int i = 0; i < keyValues.Length; i++)
            {
                Console.WriteLine("Adı ve Numarası" + keyValues[i]);
            }
        }
    }
}
