using Marathon_OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Marathon_OOP2
{
    internal class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public CustomerType Type { get; set; }
    }
}