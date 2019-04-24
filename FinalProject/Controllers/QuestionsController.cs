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
    public class QuestionsController : ApiController
    {
        private readonly IQuestionService _questionService;

        public QuestionsController()
        {
            _questionService = new QuestionService();
        }
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var questions = _questionService.GetQuestionList();
            return Ok(questions);
        }

        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            var question = _questionService.GetQuestionById(Id);
            return Ok(question);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Question question)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _questionService.Add(question);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Question question)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _questionService.Update(question);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delelte(int Id)
        {
            _questionService.Delete(Id);
            return Ok();
        }
    }
}
