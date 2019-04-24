using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Services
{
    public interface IQuestionService
    {
        List<QuestionDto> GetQuestionList();

        void Add(Question question);

        void Delete(int Id);

        QuestionDto GetQuestionById(int Id);
    }
    public class QuestionService : IQuestionService
    {
        private readonly QuestionRepository questionRepository = new QuestionRepository();
        public void Add(Question question)
        {
            questionRepository.AddQuestion(question);
        }

        public void Delete(int Id)
        {
            questionRepository.DeleteQuestion(Id);
        }

        public QuestionDto GetQuestionById(int Id)
        {
            var question = questionRepository.GetQuestionById(Id);

            return question.ToQuestionDto();
        }

        public List<QuestionDto> GetQuestionList()
        {
            var questionRepository = new QuestionRepository();

            var questionList = questionRepository.GetListOfQuestion();

            return questionList.Select(x => x.ToQuestionDto()).ToList();
        }
    }
}
