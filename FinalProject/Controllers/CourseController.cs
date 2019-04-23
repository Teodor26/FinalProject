using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class CourseController : ApiController
    {
        public ICourseService courseService;

        public CourseController()
        {
            courseService = new CourseService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = courseService.GetCourseList();
            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Course course)
        {
            courseService.Add(course);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            courseService.Delete(Id);
            return Ok();
        }
    }
}
