using System.Collections.Generic;

namespace FinalProject.BusinessLogic.Dto
{
    public class QuestionDto
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public List<MultichoiceAnswerDto> MultichoiceAnswersList { get; set; }

        public List<TextAnswerDto> TextAnswersList { get; set; }

    }
}
