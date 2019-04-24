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
            var users = _userService.GetUserList();
            return Ok(users);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var user = _userService.GetById(Id);
            return Ok(user);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] User user, string role)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _userService.Add(user, role);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _userService.Update(user);

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
