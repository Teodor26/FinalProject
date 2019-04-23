using FinalProject.BusinessLogic.Services;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectWeb.Controllers
{

    public class HomeController : Controller
    {
        #region Register  

        //  
        // GET: /Home/Register  
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //  
        // POST: /Home/Register  
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Info.  
                Console.WriteLine(model.Email);
            }

            // If we got this far, something failed, redisplay form  
            return View(model);
        }

        #endregion
    }
}