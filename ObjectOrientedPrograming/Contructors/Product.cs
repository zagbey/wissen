using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{
    class Product
    {
        //constructor metot 
        //yapıcı metot

        //bir sınıf yazdığımızda constructor metodu özellşjler yazmasak da otomatik olarak parametresiz bir constructor kendiliğinden sınıfa eklenir(derleme aşamasında )

        //Constructor nasıl yazılır?
        //1.Access modfier yazılır 
        //2.sınıf (tip) adını yazarız
        //3.parametreler 

        //Method overlodaing 
        public Product()
        {


        }
        //Constructor chaining 
        public Product(string name):this(name,default)
        {

        }
        public Product (string name,decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;

        }
        
          
       
        private string _name;
        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value.Trim();
            }

        }

        public decimal UnitPrice { get; set; }

        
    }

}
