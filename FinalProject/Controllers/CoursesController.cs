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

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var course = _courseService.GetById(Id);
            return Ok(course);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Course course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _courseService.Add(course);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Course course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _courseService.Update(course);

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
