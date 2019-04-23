using FinalProject.BusinessLogic.Services;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService groupService 
            = new GroupService();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var course = groupService.GetGroupList();
            var groupViewModel = course.Select(x => new GroupViewModel(x));

            return View(groupViewModel); ;
        }


    }
}