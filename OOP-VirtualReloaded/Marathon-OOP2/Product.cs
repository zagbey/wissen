using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Marathon_OOP2
{
    //mümkün olduğunca bir backing fielda kendi propertisy ulaşsın 
    internal class Product
    {
        // name -> Parametre (parameter)
        // Runtime'da name'e gönderilen değer -> Argüman (argument)
        public Product(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                //const string paramName = "name";
                //throw new ArgumentNullException(paramName);

                throw new ArgumentNullException(nameof(name));
            }

            //Name = name.Trim();
            //_name = name;
            Name = name.Trim();
        }

        // set metodunun başına private Access Modifier'ı ekleyerek bir property
        // bu sınıfın dışarısındaki dünya için readonly yapabiliriz
        //public string Name { get; private set; }

        // readonly olarak işaretlenmiş field'ların değeri
        // YALNIZCA CONSTRUCTOR METOTTA DEĞİŞTİRİLEBİLİR
        //private readonly string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //}


        // Bu yöntem, yukarıdaki readonly field ile birlikte geliştirilmiş yalnızca get
        // metodu olan Property örneğinin çok kısaltılmış hali
        public string Name { get; }

        // Breaking Changes

        // Özet olarak; (Computed property olmamak kaydıyla) değer tutan bir Property üyeyi
        // dış dünyaya salt okunur yapabilmek için iki yöntemden bahsedebiliriz
        // 1. set metodunu private yap. Bu şekilde sınıftaki tüm metotlar o property değerini
        // set edebilirken dış dünya bu değeri değiştiremez
        // 2. set metodunu tamamen sil. Bu şekilde property'nin otomatik olarak oluşturulacak
        // backing field'ı readonly şeklinde oluşturulur, ve bu sayede bu Property değeri
        // yalnızca constructor metot tarafından değiştirilebilir


        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value >= 0 ? value : default;
            }
        }

        //public void ChangeName(string value)
        //{
        //    _name = value;
        //    Name = value;
        //}

    }
}
