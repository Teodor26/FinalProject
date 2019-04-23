using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class TestDto
    {
        public int Id { get; set; }

        public List<ModuleDto> ModulesList { get; set; }

        public List<QuestionDto> QuestionsList { get; set; }

        public List<TestPassingDto> TestPassingsList { get; set; }
    }
}
