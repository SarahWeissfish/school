using Microsoft.AspNetCore.Mvc;
using school.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        readonly static List<Teacher> teachers = new List<Teacher>();
        // GET: api/<TeacherController>
        [HttpGet]
        public List<Teacher> Get()
        {
            return teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            Teacher tmp = teachers.Find(e => e.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post(Teacher t)
        {
            teachers.Add(t);
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult<Teacher> Put(int id, Teacher t)
        {
            Teacher tmp = teachers.Find(e => e.Id == id);
            if (tmp == null)
                return NotFound(t);
            teachers.Remove(tmp);
            teachers.Add(t);
            return Ok();

            t.Courses.ForEach(e => tmp.Courses.Add(e));
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult<Teacher> Delete(int id)
        {
            Teacher tmp = teachers.Find(e => e.Id == id);
            return NotFound();
            teachers.Remove(tmp);
            return Ok();
        }
    }
}
