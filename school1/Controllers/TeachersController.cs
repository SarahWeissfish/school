using Microsoft.AspNetCore.Mvc;
using school.Entities;
using school1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        DataContext dataContext;

        // GET: api/<TeacherController>
        [HttpGet]
        public List<Teacher> Get()
        {
            return dataContext.teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            Teacher tmp = dataContext.teachers.Find(e => e.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post(Teacher t)
        {
            dataContext.teachers.Add(t);
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult<Teacher> Put(int id, Teacher t)
        {
            Teacher tmp = dataContext.teachers.Find(e => e.Id == id);
            if (tmp == null)
                return NotFound(t);
            dataContext.teachers.Remove(tmp);
            dataContext.teachers.Add(t);
            return Ok();

            t.Courses.ForEach(e => tmp.Courses.Add(e));
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult<Teacher> Delete(int id)
        {
            Teacher tmp = dataContext.teachers.Find(e => e.Id == id);
            return NotFound();
            dataContext.teachers.Remove(tmp);
            return Ok();
        }
    }
}
