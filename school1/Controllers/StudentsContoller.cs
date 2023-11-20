using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Infrastructure;
using school.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly static List<Student> students = new List<Student>();
        // GET: api/<Student>
        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        // GET api/<Student>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student tmp = students.Find(e => e.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }

        // POST api/<Student>
        [HttpPost]
        public void Post(Student s)
        {
            students.Add(s);
        }

        // PUT api/<Student>/5
        [HttpPut("{id}")]
        public ActionResult<Student> Put(int id, Student s)
        {

            Student temp = students.Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            students.Remove(temp);
            students.Add(s);
            return Ok(s);

        }

        // DELETE api/<Student>/5
        [HttpDelete("{id}")]
        public ActionResult<Student> Delete(int id)
        {
            Student temp = students.Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            students.Remove(temp);
            return Ok();
        }
    }
}
