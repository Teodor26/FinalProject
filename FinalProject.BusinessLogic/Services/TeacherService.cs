using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Services
{

    public interface ITeacherService
    {
        List<TeacherDto> GetTeacherList();

        TeacherDto GetTeacherId(int Id);

        void Add(Teacher teacher);

        void Update(Teacher teacher);

        void Delete(int Id);
    }
    public class TeacherService : ITeacherService
    {

        private readonly TeacherRepository teacherReposotiry
            = new TeacherRepository();

        public void Add(Teacher teacher)
        {
            teacherReposotiry.AddTeacher(teacher);
        }

        public void Delete(int Id)
        {
            teacherReposotiry.DeleteTeacher(Id);
        }

        public TeacherDto GetTeacherId(int Id)
        {
            var teacher = teacherReposotiry.GetTeacheryId(Id);

            return teacher.ToTeacherDto();
        }

        public void Update(Teacher teacher)
        {
            teacherReposotiry.UpdateTeacher(teacher);
        }

        public List<TeacherDto> GetTeacherList()
        {
            var teacherList = teacherReposotiry.GetListOfTeachers();

            return teacherList.Select(x => x.ToTeacherDto()).ToList();
        }
    }
}
