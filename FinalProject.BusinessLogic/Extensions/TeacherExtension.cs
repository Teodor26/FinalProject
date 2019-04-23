using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            if (teacher == null)
                return null;

            var teacherDto = new TeacherDto
            {
                Id = teacher.Id,
                TestPassingList = teacher.TestPassings.Select(x => x.ToTestPassingDto()).ToList(),
                CoursesList = teacher.Courses.Select(x => x.ToCourseDto()).ToList(),
                GroupsList = teacher.Groups.Select(x => x.ToGroupDto()).ToList()
            };

            return teacherDto;
        }
    }
}
