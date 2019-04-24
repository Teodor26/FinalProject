﻿using FinalProject.BusinessLogic.Services;
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
            var courses = _groupService.GetGroupList();
            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Group group, string Course)
        {
            _groupService.Add(group, Course);
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
