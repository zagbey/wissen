using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02

{
    //sınıf---> terzinin kullandığı kalıplar 
    //nesne---> elbise (object, instance)
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Ürün fiyatı negatif değer olamaz
        // UnitPrice'ı full property şeklinde yazıp, eğer
        // negatif bir değer set ediliyorsa onun yerine
        // ürün fiyatına 0 yazın
        private decimal _unitPrice;
        public decimal UnitPrice
        {
            get
            { return _unitPrice; }
            set
            {
                if (_unitPrice > 0)
                {
                    _unitPrice = value;

                }
                else
                {
                    _unitPrice = 0;
                }
            }
        }


        public bool IsActive { get; set; }

        public int Stock { get; set; }
        public bool HasStock //readonly
        {
            get
            {
                return Stock > 0;
            }
        }

        public string HasStockString
        {
            get
            {
                return HasStock ? "Stoğu var" : "Tükenmiş";
            }
        }
    }
}
