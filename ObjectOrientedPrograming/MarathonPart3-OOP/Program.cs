using MarathonPart3_OOP;

var student = new Student()
{
    FirstName = "Tsubasa",
    LastName = "Ozora"
};

student.AddExamGrade(95);
student.AddExamGrade(45);
student.AddExamGrade(95);
student.AddExamGrade(45);
student.AddExamGrade(95);
student.AddExamGrade(45);
student.AddExamGrade(95);
student.AddExamGrade(45);
student.AddExamGrade(95);
student.AddExamGrade(44);

//student.AddExamGrade(100);

Console.WriteLine($"{student.FullName} isimli öğrencinin not ortalaması: {student.GradeAverage}");
Console.WriteLine(student);




// var -> Değişken oluşturmak için özel bir keyword
// var keyword'ü variable kelimesinin kısaltması
var number = 100;
