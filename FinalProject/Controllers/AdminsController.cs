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
    public class AdminsController : ApiController
    {
        private readonly IAdminService _adminService;

        public AdminsController()
        {
            _adminService = new AdminService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var admin = _adminService.GetAdminList();
            return Ok(admin);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var admin = _adminService.GetAdminById(Id);
            return Ok(admin);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Admin admin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _adminService.Add(admin);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Admin admin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _adminService.Update(admin);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _adminService.Delete(Id);
            return Ok();
        }
    }
}
