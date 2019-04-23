using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System.Linq;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ModuleExtension
    {

        public static ModuleDto ToModuleDto(this Module module)
        {
            if (module == null)
                return null;

            var moduleDto = new ModuleDto
            {
                Id = module.Id,
                QuantityLessons = module.QuantityLessons.Value,
                QuestionList = module.Questions.Select(x => x.ToQuestionDto()).ToList(),
                ThemeList = module.Themes.Select(x => x.ToThemeDto()).ToList()
            };
            return moduleDto;
        } 
         
    }
}
