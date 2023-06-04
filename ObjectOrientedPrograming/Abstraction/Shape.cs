using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    internal abstract class Shape
    {
        //Her ne kadar Shape sınıfı soyut bir sınıf olup new Shape() yazımı ile instance alınamıyor olsamda ,Shape sınıfının consturucot metodu çağırılabilir
        //bu metodu doğrudan instance alamasamda Shapesınıfı miras almış Rectangle ve Circle sınıflarından new Rectangle() instane alırken Shape() constuructor metodu otomatik olarak çağırılır 
        //ctor yazarsan constructoru otomatik oluşturuyor 

        //bu "miras alınan sınıfın constructor metodunu çağırma "olayına "contructor chaining deniyo
        //constructor chaining yanlızca abstract(soyut) sınıflar için geçerli değil miras alınan tüm sınıflarda bu zincirleme contructor çağırımı otomatik olarka meydana geliyor 
        public Shape(string name) // shape burada gidip objeckte bakıyo sonra gelip kendi gövedisine bakıyor 
        {
            _name = name;
        }
        private string _name;

        //virtual
        //virtual ile yanlızca sınıf üyelerini işaretleyebiliriz
        //sınıflar virtual yapılamaz

        //virtual ile işaretlenmil bir üyenin (metod,property)varsayılan bir implementtationu olur
        //o sınıfı miras almış olan diğer sınıfa gerektiği taktirde virtual üye override edilebilir 
        //yani virtual bir üyeyi yar-soyut hale getirir diyebiliriz 
        public virtual string Name
        {
            get
            {
                return _name;
            }
        }
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public override string ToString() // objeckt sınıftan tanımlanmış bir fonksiyon bunun davranışını değiştiriyoruz değiştirebilmemizi ToString virtual olarak tanımlanması
        {
            return $"{Name},Çevresi:{CalculatePerimeter},Alanı{CalculateArea}"; // bu tanımı yaptıktan sonra ToString çağırıldığında gövdedeki işlemi çevirecek  
        }

    }
}
