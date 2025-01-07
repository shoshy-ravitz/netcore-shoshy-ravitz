using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Entities;
using swimmingLwssons.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimmingLwssons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public StudentService StudentService= new StudentService();
        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return StudentService.GetStudent();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student>  Get(int id)
        {
            return StudentService.GetStudentByCode(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Student student)
        {
            return StudentService.AddStudent(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int Code, [FromBody] Student student)
        {
            if( StudentService.UpdateStudent(Code, student))
                return Ok();
             return NotFound();
        }
        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (StudentService.DeleteStudent(id))
                return Ok();
            return NotFound();
        }
    }
}
