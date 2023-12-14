namespace ConsoleApp14122023.Domain.Models
{
    public class Group
    {
        private static int _groupNo = 101;
        public string GroupNo { get; set; }
        //public List<Student> Student { get; }

        public Group()
        {
            Students = new List<Student>();
            GroupNo = $"AP{_groupNo++}";
        }
        private List<Student> Students { get; set; }

        public List<Student> AddStudent(Student student)
        {
            Students.Add(student);
            return Students;
        }
        public List <Student> GetAllStudents()
        {
            return Students;
        }
        public List<Student> Sort()
        {
            List<Student> result = new List<Student>(Students);
            result.Sort ((student1, student2) => student1.Point.CompareTo(student2.Point));
            return result;
        }
    }
}
