using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //soyut sınıfların instancesı alınamaz Cricle circle = new Circle yani xd
    //sadece miras alınırlar 
    internal class Circle:Shape
    {
        public Circle():base("daire")
        {
            
        }
        public double Radius { get; set; }

        public override double CalculatePerimeter()
        {
            return 2* Radius* Math.PI;
        }
        
        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2);
        }
    }
}
