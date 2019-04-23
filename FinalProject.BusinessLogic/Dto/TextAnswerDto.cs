using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class TextAnswerDto
    {
        public int Id { get; set; }
        public string Textbox { get; set; }

        public int IsCorrect { get; set; }
    }
}
