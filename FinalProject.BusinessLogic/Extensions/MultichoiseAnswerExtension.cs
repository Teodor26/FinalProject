using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class MultichoiseAnswerExtension
    {
        public static MultichoiceAnswerDto ToMultichoiceAnswerDto(this MultichoiceAnswer multichoice)
        {
            if (multichoice == null)
                return null;

            var multichoiceDto = new MultichoiceAnswerDto
            {
                Id = multichoice.Id,
                AnswerText = multichoice.AnswerText,
                IsCorrect = multichoice.IsCorrect.Value,
            };

            return multichoiceDto;
        }
    }
}
