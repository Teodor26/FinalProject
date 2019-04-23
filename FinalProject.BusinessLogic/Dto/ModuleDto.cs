using System.Collections.Generic;

namespace FinalProject.BusinessLogic.Dto
{
    public class ModuleDto
    {
        public int Id { get; set; }
        public int QuantityLessons { get; set; }        

        public List<QuestionDto> QuestionList { get; set; }

        public List<ThemeDto> ThemeList { get; set; }
    }
}
