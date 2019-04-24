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
            var themes = _themeService.GetThemeList();
            return Ok(themes);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var theme = _themeService.GetThemeById(Id);
            return Ok(theme);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Theme theme)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _themeService.Add(theme);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Theme theme)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _themeService.Update(theme);

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
