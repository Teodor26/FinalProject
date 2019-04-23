using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public List<TestPassingDto> TestPassingList { get; set; }

        public List<CourseDto> CoursesList { get; set; }

        public List<GroupDto> GroupsList { get; set; }
    }
}
