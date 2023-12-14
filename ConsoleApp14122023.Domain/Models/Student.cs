namespace ConsoleApp14122023.Domain.Models
{
    public class Student
    {
        private static int _iD = 1;
        public int Id { get;}
        public string Name { get; set;}
        public string SurName { get; set;}
        public int Age { get; set;}
        public int Point {  get; set;}

        public Student (string name, string surname, int age, int point )
        {
            _iD++;
            Id = _iD;
            Name=name;
            SurName=surname;
            Age=age;
            Point=point;           
        }
        public void ShowInfo()
        {
           Console.WriteLine($"Name {Name}-i , SurName {SurName}-i, Age {Age}-i, Point {Point}-i, ID {Id}-si" );
        }
        public static bool comparemin (Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
        public static bool comparemax (Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
    }
}
