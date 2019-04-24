using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class TeacherRepository
    {
        public List<Teacher> GetListOfTeachers()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                var teachers = context.Teachers.
                    Include("User").
                    Include("TestPassings").
                    Include("Courses").
                    Include("Groups").
                    ToList();
                return teachers;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Teachers.Add(teacher);
            }
        }

        public void DeleteTeacher(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Teacher teacher = context.Teachers.Find(Id);
                context.Teachers.Remove(teacher);
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Teacher GetTeacheryId(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Teachers.Find(Id);
            }
        }
    }
}
