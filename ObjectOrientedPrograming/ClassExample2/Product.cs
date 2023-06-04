using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string Color { get; set; }
        public int StochAmount { get; set; }
        public bool IsActive { get; set; }

        //Constructor chaining 
        public Product(string name) : this(name,default)
        {
            
        }
        public Product(string name,int price):this(name,price,default)
        {
            
        }
        public Product(string name,decimal price,string categoryName)
        {
            Name = name;
            Price = price;
            CategoryName = categoryName;
        }
    }
  
}
