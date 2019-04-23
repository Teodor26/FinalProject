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
        private readonly IGroupService groupService;

        public GroupsController()
        {
            groupService = new GroupService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = groupService.GetGroupList();
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Group group, string Course)
        {
            groupService.Add(group, Course);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            groupService.Delete(Id);
            return Ok();
        }

    }
}
