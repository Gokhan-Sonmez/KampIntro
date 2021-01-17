using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi" + " : " + product.ProductName);
        }
        
        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi" + " : " + urunAdi);
        }
    }
}
