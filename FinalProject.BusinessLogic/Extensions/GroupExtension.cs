using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class GroupExtension
    {
        public static GroupDto ToGroupDto(this Group group)
        {
            if (group == null)
                return null;

            var groupDto = new GroupDto
            {
                Id =group.Id,
                Name = group.Name,
                BeginingDate = group.BeginigDate.Value,
                StudentsList = group.Students.Select(x => x.ToStudentDto()).ToList(),
                TeachersList = group.Teachers.Select(x => x.ToTeacherDto()).ToList()
            };

            return groupDto;
        }
    }
}
