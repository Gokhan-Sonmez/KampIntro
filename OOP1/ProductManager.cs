using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            product.ProductName = product.ProductName + " eklendi.";

        }
        public void Update(Product product)
        {
            product.ProductName = product.ProductName + " güncelendi.";

        }

        
    }
}
