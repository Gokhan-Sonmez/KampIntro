using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class Operations
    {
        public void Topla(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine("Sonuç : " + toplam);

        }

        public void Cikar(int a, int b)
        {
            int cikar = a - b;
            Console.WriteLine("Sonuç : " + cikar);
        }
    }
}
