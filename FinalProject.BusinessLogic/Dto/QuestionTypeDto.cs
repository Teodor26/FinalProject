using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class QuestionTypeDto
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public List<QuestionDto> QuestionsList { get; set; }
    }
}
