using System.Collections.Generic;

namespace FinalProject.BusinessLogic.Dto
{
    public class ThemeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<QuestionDto> QuestionList { get; set;}

    }
}
