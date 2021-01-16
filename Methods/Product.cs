using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //encapsulation --kapsülleme --  Daha sonradan özellik ekleyip programın akışını bozmadan devam ediyoruz.
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Explanation { get; set; }
        public int UnitInStock { get; set; }
    }
}
