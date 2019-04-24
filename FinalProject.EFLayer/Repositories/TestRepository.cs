using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class TestRepository
    {
        public IEnumerable<Test> GetListOfTest()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Tests.ToList();
            }
        }

        public void AddTest(Test test)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Tests.Add(test);
            }
        }

        public void DeleteTest(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Test test = context.Tests.Find(Id);
                context.Tests.Remove(test);
            }
        }

        public void UpdateTest(Test test)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(test).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Test GetTestById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Tests.Find(Id);
            }
        }
    }
}
