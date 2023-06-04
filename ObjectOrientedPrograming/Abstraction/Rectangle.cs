using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction // soyutlama 
{
    internal class Rectangle:Shape
    {
        //BUNUN ADI CONSTRUCTOR xd
        public Rectangle():base("dikdörtgen")  // biz bunu yazmamış olsakda otomatik ekliyor  // en ata köküne gidene kadar o contructoru çalıştırıyor sonra kendisini çalıştırıyor 
                                                                           // mesela Shape constructorun'da ekleme yapmadık objeckt e gidip bakıyor sonra shapeyi çalıştırıyor 
                            
        {


        }
        public double SideA {  get; set; } //field 
        //property fieldlerın kapsüllenmüş halde dışarıya aktaran şey 
        public double SideB {  get; set; }

        public override double CalculatePerimeter()
        {
            return 2*(SideA+SideB);   
        }

        public override double CalculateArea()
        {
            return SideA*SideB;
        }

        //ToString fonksiyonu Shape sınıfı seviyesinde bir kere override edilmiş 
        //olmasına rağmen Shape sınıflarını miras alan diğer sınıflarda halaezilebilirler
        //virtual veya abstract bir üye.bir sınıfın soy ağacı boyunca her seviyede 
        //ayrı ayrı implement edilebilir 
        public override string ToString()
        {
            return $"{base.ToString()},kenar uzunlukları : {SideA},{SideB}";
        }
    }
}
