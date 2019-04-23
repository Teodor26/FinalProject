using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class UserTypeDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<UserDto> UsersList { get; set; }
    }
}
