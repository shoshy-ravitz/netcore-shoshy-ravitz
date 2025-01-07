using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Entities;
using swimmingLwssons.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimmingLwssons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        public LessonService lessonService=new LessonService();
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult<List<Lesson>> Get()
        {
            return lessonService.GetLessons();
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Lesson> Get(int id)
        {
            if (lessonService.GetLessonByCode(id) == default)
                return NotFound();
            return Ok(lessonService.GetLessonByCode(id));
        }

        // POST api/<LessonController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Lesson lesson)
        {
            if (lessonService.AddLesson(lesson))
                return Ok();
            return NotFound();
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Lesson lesson)
        {
            if (lessonService.UpdateLesson(id,lesson))
                return Ok();
            return NotFound();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (lessonService.DeleteLesson(id))
                return Ok();
            return NotFound();
        }
    }
}
