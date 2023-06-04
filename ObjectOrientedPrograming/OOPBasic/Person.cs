namespace OOPBasic
{
    class Person
    {
        // CLASS MEMBERS -> Sınıf Üyeleri
        // 1. Field              : sınıf içerisinde değerleri/verileri tutan birimler
        // 2. Method (fonksiyon) : nesnelerin eylemlerin/davranışları
        // Örnek1: Bir araç için aracı Çalıştır(), Durdur()
        // Örnek2: Bir kişi için Yürü(), Dur(), Uyu()

        // 3. Property (özellik) : nesnelerin özellikleri 
        // Örnek1: Kişiler için İsim, Doğum tarihi vs..
        // Örnek2: Bir araç için Motor Silindir Hacmi, Yakıt Tipi
        // Örnek3: Bir bilgisayar ekranı için Çözünürlük, Renk modları vs.

        // Bir sınıf üyesinin en başına yazdığımız public/private ifadelerine
        // ACCESS MODIFIER deniyor (erişim belirteci)
        private string _firstName; // Field, alan
        // Field: Sınıf içerisinde değerleri/verileri tutan birimler
        public string FirstName { get; set; } // Auto property 

        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}


        // public -> Sınıf dışından görünebilir, açık
        // private -> Yalnızca o sınıf içerisinden erişilebilir, gizli
        // Eğer bir field'a access modifier yazılmazsa otomatik olarak
        // private ilan ediliyor

        public string _lastName; // Field

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        // OOP Concepts (OOP Kavramları)
        // 1. Encapsulation
        // Dış dünyayı ilgilendirmeyen detayların (veri ve davranışların)
        // nesne içerisinde gizlenmesi ve dış dünyayı ilgilendiren kısımların
        // (veri ve davranışların) public olarak sunulması

        private long _ıdentityNumber; // Field

        public void SetIdentityNumber(long value)
        {
            if (value > 0)
            {
                _ıdentityNumber = value;
            }
            else
            {
                _ıdentityNumber = Math.Abs(value);
            }
        }

        public long GetIdentityNumber()
        {
            return _ıdentityNumber;
        }


        // Eğer bir field private ise genellikle aşağıdaki isimlendirme
        // standartı kullanılır
        // _camelCase
        private int _age; // backing field

        public int Age // Property
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        //public void SetAge(int value)
        //{
        //    if (value > 0)
        //    {
        //        _age = value;
        //    }
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException();
        //    }
        //}

        //public int GetAge()
        //{
        //    return _age;
        //}


        // Method
        public string Talk()
        {
            return "Hello world";
        }

        // Method
        public string Introduce()
        {
            return $"Benim adım {_firstName}";
        }

    }
}