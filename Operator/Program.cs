// See https://aka.ms/new-console-template for more information
using OperatorOverloading;

Lesson lesson = new() { Name="Matematik"};
Student student = new Student() { 
Name = "Faik"};

//Toplama operatörünü Lesson sınıfı içerisinde operatör overloading yaparak toplama operatörüne yeni bir görev atamış olduk. Bu sayede eğer bir öğrenci ile bir ders nesnesini biz toplamasını istersek, o dersi öğrenciye atayacak bir hale getirmiş oluyoruz.
Student studentWithLesson = student + lesson;

foreach (var item in studentWithLesson.Lessons)
{
    Console.WriteLine(item.Name);
}




Console.WriteLine("Hello, World!");
