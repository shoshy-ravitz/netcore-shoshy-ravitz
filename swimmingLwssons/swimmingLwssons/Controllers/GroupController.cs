using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Services;
using swimmingLwssons.Entities;
using System.Threading.Tasks.Dataflow;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace swimmingLwssons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public GroupService GroupService =new GroupService();
        // GET: api/<GroupController>
        [HttpGet]
        public ActionResult<List<Group>> Get()
        {
            if(GroupService.GetGroups()==null)
                return NotFound();
            return Ok(GroupService.GetGroups());
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public ActionResult<Group> Get(int code)
        {
            if (GroupService.GetGroupByCode(code) == default)
                return NotFound();
            return Ok(GroupService.GetGroupByCode(code));
        }

        // POST api/<GroupController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Group group)
        {
            if (group == null) return Unauthorized();
            if(GroupService.AddGroup(group))
                return Ok();
            return NotFound();
        }
        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Group group)
        {
            if(group==null) Unauthorized();
            if(GroupService.UpdateGroup(id,group))
                return Ok();
            return NotFound();

        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if(GroupService.DeleteGroup(id))
                return Ok();
            return NotFound();
        }
    }
}
