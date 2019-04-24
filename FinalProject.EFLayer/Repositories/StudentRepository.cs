using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class StudentRepository
    {
        public List<Student> GetListOfStudents()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                var students = context.Students.
                    Include("User").
                    Include("TestPassings").
                    Include("Groups").
                    ToList();

                return students;
            }
        }

        public void AddStudent(Student student)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Students.Add(student);
            }
        }

        public void DeleteStudent(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Student student = context.Students.Find(Id);
                context.Students.Remove(student);
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Student GetStudentById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Students.Find(Id);
            }
        }
    }
}
