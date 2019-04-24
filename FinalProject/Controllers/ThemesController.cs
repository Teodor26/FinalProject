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
    public class ThemesController : ApiController
    {
        private readonly IThemeService _themeService;

        public ThemesController()
        {
            _themeService = new ThemeService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var courses = _themeService.GetThemeList();
            return Ok(courses);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Theme theme)
        {
            _themeService.Add(theme);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _themeService.Delete(Id);
            return Ok();
        }
    }
}
