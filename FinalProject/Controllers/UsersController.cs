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
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = _userService.GetUserList();
            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] User user, string role)
        {
            _userService.Add(user, role);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _userService.Delete(Id);
            return Ok();
        }
    }
}
