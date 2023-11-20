namespace school.Entities
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public Teacher()
        {

        }
        public Teacher(string name, int id, int age, int experience)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.Experience = experience;

        }
    }
}
