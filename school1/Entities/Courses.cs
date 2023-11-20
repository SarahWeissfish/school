namespace school.Entities
{
    public class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public Course()
        {

        }
        public Course(string name, int id, int price, string location)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.Location = location;
        }

    }
}
