namespace school.Entities
{
    public class Student
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Fees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<int> Marks { get; set; } = new List<int>();
        public Student() { }

        public Student(string name, int id, int age, int fees)
        {
            this.Name = name;
            this.Age = age;
            this.Fees = fees;
            this.Id = id;
        }

    }
}
