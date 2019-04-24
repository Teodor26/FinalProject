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
    public class TeachersController : ApiController
    {
        private readonly ITeacherService _teacherService;

        public TeachersController()
        {
            _teacherService = new TeacherService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var teachers = _teacherService.GetTeacherList();
            return Ok(teachers);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var teacher = _teacherService.GetTeacherId(Id);
            return Ok(teacher);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _teacherService.Add(teacher);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _teacherService.Update(teacher);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _teacherService.Delete(Id);
            return Ok();
        }
    }
}
