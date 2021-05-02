using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> Adyas2 = new MyDictionary<string, int>();

            Adyas2.Add("Amy", 5);
            Adyas2.Add("Ken", 4);
            Adyas2.Add("Yen", 3);
            Adyas2.Add("Ben", 2);

            for (int i = 0; i < Adyas2.Count; i++)
            {
                Console.WriteLine("Adı : {0} Yaşı: {1}",Adyas2.Keys[i], Adyas2.Values[i]);
            }

            foreach (var item in Adyas2)
            {
                Console.WriteLine(item);
            }
            




        }
    }
}
