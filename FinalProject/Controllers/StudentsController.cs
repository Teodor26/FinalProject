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
            var students = studentService.GetStudents();
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var student = studentService.GetStudentById(Id);
            return Ok(student);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            studentService.Add(student);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Student student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            studentService.Update(student);

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
