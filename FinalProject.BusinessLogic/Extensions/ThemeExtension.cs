using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ThemeExtension
    {

        public static ThemeDto ToThemeDto(this Theme theme)
        {
            if (theme == null)
                return null;

            var themeDto = new ThemeDto
            {
                Id = theme.Id,
                Name = theme.Name,
                QuestionList = theme.Questions.Select(x => x.ToQuestionDto()).ToList()
            };

            return themeDto;
        }
    }
}
