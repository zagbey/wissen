using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Mause:Product
    {
        public double Dpi { get; set; }
        public int ButtonCount { get; set; }

        private double _keyCout;
        public double KeyCount
        {
            get
            {
                return _keyCout;
            }
            set
            {
                if(_keyCout <0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public double Type { get; set; }
    }
}
