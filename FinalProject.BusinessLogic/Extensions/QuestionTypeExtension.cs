using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class QuestionTypeExtension
    {
        public static QuestionTypeDto ToQuestionTypeDto(this QuestionType questionType)
        {
            if (questionType == null)
                return null;

            var questionTypeDto = new QuestionTypeDto
            {
                Id = questionType.Id,
                Type = questionType.Type,
                QuestionsList = questionType.Questions.Select(x => x.ToQuestionDto()).ToList()
            };

            return questionTypeDto;
        }
    }
}
