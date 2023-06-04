using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Student
    {
        // Özellikler 

        //Adı

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set { _firstName = value; }
        }

        //Soy Adı              //set-->writable
        //                     //get-->readable 
        public string LastName { get; set; }

        //Tam Adı 

        //readonly prorety 
        public string FulName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        //Doğum Tarihi
        public DateTime BirthDate { get; set; }
        //Yaşı 
        public int Age
        {
            get
            {   
                //COMPUTED--> hesap edilmiş değer 
                //kendisine ait bir backing field ı yoktur 
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

        public string Introduce
        {
            get
            {
                return $" Merhaba, ben {FulName}{Age} yaşındayım";
            }
        }
    }
}
