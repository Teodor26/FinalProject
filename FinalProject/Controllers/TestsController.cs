using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class TestsController : ApiController
    {
        private readonly ITestService testService;

        public TestsController()
        {
            testService = new TestService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = testService.GetTestList();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Test test)
        {
            testService.Add(test);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            testService.Delete(Id);
            return Ok();
        }
    }
}
