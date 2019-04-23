using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public List<AdminDto> AdminsList { get; set; }

        public List<StudentDto> StudentsList { get; set; }

        public List<TeacherDto> TeachersList { get; set; }
    }
}
