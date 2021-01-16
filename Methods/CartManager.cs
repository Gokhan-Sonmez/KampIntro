using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        //normal parantez varsa bir method çalışıyor
        //reusability
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi" + " : " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi" + " : " + product.ProductName);
        }
    }
}
