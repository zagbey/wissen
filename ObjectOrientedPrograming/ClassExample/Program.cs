using ClassExample;

Student student = new Student();

student.FirstName = "Zeynel abidin";
student.Lastname = "Gencer";
student.DateOfBirth = new DateTime(1996, 09, 17);
student.Classroom = "WİSSEN FullStack";
student.StudentNumber = "55";

student.AddExamGrade(100);
student.AddExamGrade(95);
student.AddExamGrade(97);
student.AddExamGrade(97);
student.AddExamGrade(97);
student.AddExamGrade(97);
student.AddExamGrade(97);
student.AddExamGrade(97);
student.AddExamGrade(97);

Console.WriteLine("Öğrenci Bilgileri");
Console.WriteLine("Adı: "+student.FirstName);
Console.WriteLine("Soyadı: "+student.Lastname);
Console.WriteLine("Doğum Tarihi: "+student.DateOfBirth);
Console.WriteLine("Öğrenci numarası: "+student.StudentNumber);
Console.WriteLine("Sınıfı: "+student.Classroom);
Console.WriteLine("Not Ortalaması: "+student.GradeAverage);
Console.WriteLine("Mezun durumu: "+(student.IsGraduated?"Mezun":"Mezun değil"));

Console.WriteLine("Öğrenci Sınav Notları");


    