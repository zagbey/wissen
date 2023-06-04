using Inheritance;
// Inheritance -> Bir sınıfın başka bir sınıftan özellikleri, metotları
// (kısaca o sınıfın üyelerini) miras olarak kendisine devralmasıdır

Teacher teacher = new Teacher();

teacher.Name = "roberto";
teacher.FirstName = "mançini";

Student student = new Student();
student.FirstName = "Tsubasa";
// FirstName özelliği Person sınıfından miras olarak geldi

student.LastName = "Ozora";
// LastName özelliği de aynı şekilde kalıtım sayesinde Student
// sınıfına geldi

student.StudentNumber = 239834;
// StudenNumber özelliği ise Person'dan değil, Student sınıfının
// kendisinden geldi


Teacher teacher = new Teacher();
teacher.FirstName = "Roberto";
teacher.LastName = "Hongo";
teacher.Expertise = "Yazılım";

Console.WriteLine($"Öğrenci: {student.FullName}");
Console.WriteLine($"Eğitmen: {teacher.FullName}");