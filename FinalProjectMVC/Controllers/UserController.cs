using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService userService =
            new UserService();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            var users = userService.GetUserList();
            var userViewModel = users.Select(x => new UserViewModel(x));
            return View(userViewModel);
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(User user, string role)
        {
            
            //if (ModelState.IsValid)
            //{
                userService.Add(user, role);
                return View();
            //}
            //else
                //return View(user);
        }


        public ActionResult Delete(int? Id)
        {
            userService.Delete(Id);
            return View("Index");
        }
    }
    
}