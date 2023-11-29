using Microsoft.AspNetCore.Mvc;
using school.Entities;
using school1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        DataContext dataContext;
        
        public CourseController()
        {

        }

        // GET: api/<Course>
        [HttpGet]
        public List<Course> Get()
        {
            return dataContext.courses;
        }

        // GET api/<Course>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = dataContext.courses.Find(e => e.Id == id);
            if (course == null)
                return NotFound();


            return Ok(course);

        }

        // POST api/<Course>
        [HttpPost]
        public void Post(Course c)
        {
            dataContext.courses.Add(c);
        }

        // PUT api/<Course>/5
        [HttpPut("{id}")]
        public ActionResult<Course> Put(int id, Course c)
        {
            Course temp = dataContext.courses.Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            dataContext.courses.Remove(temp);
            dataContext.courses.Add(c);

            return Ok();
        }

        // DELETE api/<Course>/5
        [HttpDelete("{id}")]
        public ActionResult<Course> Delete(int id)
        {
            Course temp = dataContext.courses.Find(e => e.Id == id);
            if (temp == null)
                return NotFound();
            dataContext.courses.Remove(temp);
            return Ok(temp);
        }
    }
}
