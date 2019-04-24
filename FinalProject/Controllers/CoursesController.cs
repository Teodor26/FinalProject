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
    public class CoursesController : ApiController
    {
        private readonly ICourseService _courseService;

        public CoursesController()
        {
            _courseService = new CourseService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = _courseService.GetCourseList();
            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Course course)
        {
            _courseService.Add(course);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _courseService.Delete(Id);
            return Ok();
        }
    }
}
