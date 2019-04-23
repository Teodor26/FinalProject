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
    public class StudentsController : ApiController
    {
        private readonly IStudentService studentService;

        public StudentsController()
        {
            studentService = new StudentService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = studentService.GetStudents();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Student student)
        {
            studentService.Add(student);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            studentService.Delete(Id);
            return Ok();
        }
    }
}
