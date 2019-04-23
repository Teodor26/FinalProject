using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class GroupDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BeginingDate { get; set; }

        public List<StudentDto> StudentsList { get; set; }

        public List<TeacherDto> TeachersList { get; set; }
    }
}
