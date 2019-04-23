using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class MultichoiceAnswerDto
    {

        public int Id { get; set; }
        public string AnswerText { get; set; }

        public int IsCorrect { get; set; }
    }
}
