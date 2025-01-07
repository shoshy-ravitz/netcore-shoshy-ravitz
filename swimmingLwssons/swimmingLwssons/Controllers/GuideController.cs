using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Services;
using swimmingLwssons.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace swimmingLwssons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {

        public GuideService GuideService =new GuideService();
        // GET: api/<GuideController>
        [HttpGet]
        public ActionResult<List<Guide>> Get()
        {
            return GuideService.GetGuides();
        }
        // GET api/<GuideController>/5
        [HttpGet("{id}")]

        public ActionResult<Guide> Get(int id)
        {
             if(GuideService.GetGuideByCode(id)==default)
                return NotFound();
              return Ok(GuideService.GetGuideByCode(id));
        }

        // POST api/<GuideController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Guide guide)
        {
            if(GuideService.AddGuide(guide))
                return Ok();
            return BadRequest();///////////////////////////////////////////////
        }

        // PUT api/<GuideController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Guide guide)
        {
            if (GuideService.UpdateGuide(id, guide))
                return Ok();
            return NotFound();
        }
        // DELETE api/<GuideController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
             if(GuideService.DeleteGuide(id))
                return Ok();
             return NotFound();
        }
    }
}
