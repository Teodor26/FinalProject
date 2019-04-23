using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TextAnswerExtension
    {
        public static TextAnswerDto ToTextAnswerDto(this TextAnswer textAnswer)
        {
            if (textAnswer == null)
                return null;

            var textAnswerDto = new TextAnswerDto
            {
                Id = textAnswer.Id,
                Textbox = textAnswer.Textbox,
                IsCorrect = textAnswer.IsCorrect.Value
            };

            return textAnswerDto;
        }
    }
}
