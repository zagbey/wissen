using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    //ctrl+m+o kapar
    //ctrl+m+p açar
    internal class Student
    {

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value.ToUpper();
            }
        }
        //private string _lastName;
        public string Lastname { get; set; }

        private DateTime _birthDate;
        public DateTime DateOfBirth
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value > DateTime.Now  //set edilen değer büyükse 
                        ? DateTime.Now                   //şuanki zamanı kabul et
                        : value;
            }
        }
        public string _studentNumber;
        public string StudentNumber
        {
            get
            {
                return _studentNumber;
            }
            set
            {
                _studentNumber = value;
            }
        }
        //public string _classroom;
        public string Classroom { get; set; }


        private double _gradeAvarage;
        public double GradeAverage
        {
            get
            {
                return _gradeAvarage;
            }
            set { _gradeAvarage = value; }


        }

        //magıc values kod içine yazılmış adı sanı belli olmayan değerler 
        public bool IsGraduated
        {
            get
            {
                return _gradeAvarage>70 && examGrades.Count > 10;
            }
            

        }
        //inlen --> constructor dışındatanımlamak 
        private List<double> examGrades;
        public Student()
        {
            examGrades = new List<double>();
        }
        public void AddExamGrade(double grade)
        {
            examGrades.Add(grade);
            GradeAverage = CalculateAverage();
        }
        private double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < examGrades.Count; i++)
            {
                sum += examGrades[i];
            }
            return sum / examGrades.Count;
        }

    }
}
