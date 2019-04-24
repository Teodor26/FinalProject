using FinalProject.BusinessLogic.Dto;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.DataLayer.Repositories;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Services
{
    public interface IStudentService
    {
        List<StudentDto> GetStudents();

        StudentDto GetStudentById(int Id);

        void Add(Student group);

        void Update(Student group);

        void Delete(int Id);
    }
    public class StudentService : IStudentService
    {
        private readonly StudentRepository studentRepository
            = new StudentRepository();

        public void Add(Student student)
        {
            studentRepository.AddStudent(student);
        }

        public void Delete(int Id)
        {
            studentRepository.DeleteStudent(Id);
        }

        public StudentDto GetStudentById(int Id)
        {
            var student = studentRepository.GetStudentById(Id);

            return student.ToStudentDto();
        }

        public void Update(Student group)
        {
            studentRepository.UpdateStudent(group);
        }

        public List<StudentDto> GetStudents()
        {
            var studentList = studentRepository.GetListOfStudents();

            return studentList.Select(x => x.ToStudentDto()).ToList();
        }
    }
}
