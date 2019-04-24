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
    public class GroupsController : ApiController
    {
        private readonly IGroupService _groupService;

        public GroupsController()
        {
            _groupService = new GroupService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var groups = _groupService.GetGroupList();
            return Ok(groups);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var group = _groupService.GetGroupById(Id);
            return Ok(group);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Group group, string Course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _groupService.Add(group, Course);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody]  Group group)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _groupService.Update(group);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _groupService.Delete(Id);
            return Ok();
        }

    }
}
