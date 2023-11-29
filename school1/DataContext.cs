using school.Entities;
using school1.Entities;

namespace school1
{
    public class DataContext
    {

        public List<Course> courses;
        public List<Student> students;
        public List<Teacher> teachers;
        public DataContext() { 
            courses = new List<Course>();   
            students = new List<Student>(); 
            teachers= new List<Teacher>();
        
        
        }
    }
}
