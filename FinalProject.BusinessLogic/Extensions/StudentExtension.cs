using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            if (student == null)
                return null;

            var studentDto = new StudentDto
            {
                Id = student.Id,
                TestPassingList = student.TestPassings.Select(x => x.ToTestPassingDto()).ToList(),
                GroupsList = student.Groups.Select(x => x.ToGroupDto()).ToList()
            };

            return studentDto;
        }
    }
}
