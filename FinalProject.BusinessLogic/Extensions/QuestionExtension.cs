using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class QuestionExtension
    {
        public static QuestionDto ToQuestionDto(this Question question)
        {
            if (question == null)
                return null;

            var questionDto = new QuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                TextAnswersList = question.TextAnswers
                                                     .Select(x => x.ToTextAnswerDto())
                                                     .ToList(),
                MultichoiceAnswersList = question.MultichoiceAnswers
                                                     .Select(x =>x.ToMultichoiceAnswerDto())
                                                     .ToList()
            };

            return questionDto;
        }
    }
}
