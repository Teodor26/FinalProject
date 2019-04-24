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
            var tests = testService.GetTestList();
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var test = testService.GetTestById(Id);
            return Ok(test);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Test test)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            testService.Add(test);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Test test)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            testService.Update(test);

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
