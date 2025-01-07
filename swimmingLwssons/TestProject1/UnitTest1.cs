using Microsoft.AspNetCore.Mvc;
using swimmingLwssons.Controllers;
using swimmingLwssons.Entities;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Get_returnListCourse()
        {
            var controller = new CourseController();
            var result = controller.Get();
            Assert.IsType<List<Course>>(result);
        }
        [Fact]
        public void GetById_returnNotFound()
        {
            int id = 2;
            var controller = new CourseController();
            var result = controller.Get(id);
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public void GetById_returnOk()
        {
            int id = 2;
            var controller = new CourseController();
            var result = controller.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}