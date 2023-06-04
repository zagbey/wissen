using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bu soru ClassExamplenin sınıfta hocanın çözdüğü versiyonu 
//ctrl+m+o kapar
//ctrl+m+p açar
namespace MarathonPart3_OOP
{
    internal class Student
    {
        // const -> CONSTANT -> sabit değer
        private const int RequiredExamCount = 10;
        //private const double GraduationCriteria = 70;

        // inline olarak initialize ettim (yani constructor'a yazmadım)
        private List<double> _grades = new List<double>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                // StringFormat: string.Format("formatlı string", parametreler)
                // StringInterpolation: $""
                // StringConcat metodu: string.Concat(parametreler)
                return string.Concat(FirstName, " ", LastName);
            }
        }

        // 01.01.0001 00:00:00.000000
        private DateTime _dateOfBirth = DateTime.Today.AddYears(-10);
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                DateTime minBirthDate = DateTime.Today.AddYears(-10);

                if (value > minBirthDate)
                {
                    _dateOfBirth = minBirthDate;
                }
                else
                {
                    _dateOfBirth = value;
                }
            }
        }
        public int StudentNumber { get; set; }
        public string Classroom { get; set; }
        public double GradeAverage
        {
            get
            {
                double total = 0;
                for (int i = 0; i < _grades.Count; i++)
                {
                    total += _grades[i];
                }

                // Eğer kodlama yaparken bir matematik bölme işlemi yazdıysanız
                // BÖLEN sayının 0 olma ihtimalini her zaman kontrol etmeye çalışın
                return _grades.Count > 0
                    ? total / _grades.Count
                    : 0;
            }
        }

        public bool IsGraduated
        {
            get
            {
                // Magic Values
                // Kod içerisine yazılmış, adı, sanı, amacı belli olmayan değerler
                //return _grades.Count >= 10 && GradeAverage >= 70;

                // Metot içi const tanımı
                const double graduationCriteria = 70;

                return
                    _grades.Count >= RequiredExamCount &&
                    GradeAverage >= graduationCriteria;
            }
        }

        public string IsGraduatedString
        {
            get
            {
                return IsGraduated ? "Mezun olmuş" : "Mezun olmamış";
            }
        }

        public void AddExamGrade(double examGrade)
        {
            if (_grades.Count < 10 || GradeAverage < 70)
            {
                _grades.Add(examGrade);
            }
            else
            {
                throw new Exception("Öğrenci zaten mezun olmuştur");
            }
        }

        public override string ToString()
        {
            return $"Toplamda {_grades.Count} adet sınava girmiş olan {FullName} {IsGraduatedString}";
        }
    }
}
    
