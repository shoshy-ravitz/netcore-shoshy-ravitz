using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Services;
using swimmingLwssons.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimmingLwssons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static CourseService CourseService = new CourseService();
        // GET: api/<CourseController>
        [HttpGet]
        public List<Course> Get()
        {
            return CourseService.GetCourses();
        }
        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            if (CourseService.GetCourseByCode(id) == default)
                return NotFound();
            return Ok(CourseService.GetCourseByCode(id)); ;
        }
        // POST api/<CourseController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Course course)
        {
            if (CourseService.AddCourse(course))
                return Ok();
            return NotFound();
        }
        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Course course)
        {
            if (CourseService.UpdateCourse(id, course))
                return Ok();
            return NotFound();
        }
        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (CourseService.DeleteCourse(id))
                return Ok();
            return NotFound();
        }
    }
}