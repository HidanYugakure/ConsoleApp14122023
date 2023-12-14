
using ConsoleApp14122023.Domain.Models;

Student student1 = new ("Fidan", "Suleymanli",24,5);
Student student2 = new ("Sehla","Bayramova",56,4);
Student student3 = new("Elsen", "Bayramov",55,3);
Student student4 = new("Semade", "Bayramova",40,2);

Group group1 = new Group();
group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
group1.AddStudent(student4);

foreach (var item in group1.GetAllStudents())
{
    Console.WriteLine($"{item.Name} {item.SurName} {item.Age} {item.Point}");
}

foreach (var item in group1.Sort())
{
    Console.WriteLine($"{item.Name} {item.SurName} {item.Age} {item.Point}");
}

Group group2 = new();
Console.WriteLine(group2.GroupNo);