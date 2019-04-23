using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using FinalProject.Models.ViewModels;
using FinalProjectMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService groupService 
            = new GroupService();


        private readonly IGroupApiService _groupApiService =
            new GroupApiService();
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> List()
        {
            var course = await _groupApiService.Getlist();
            var groupViewModel = course.Select(x => new GroupViewModel(x));

            return View(groupViewModel); ;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Group group, string Course)
        {                   

            //if (ModelState.IsValid)
            //{
                groupService.Add(group, Course);
                return View();
            //}
            //return View(group);
        }

        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return View("Index");
            }
            groupService.Delete(Id);
            return View("Index");
        }
    }
}