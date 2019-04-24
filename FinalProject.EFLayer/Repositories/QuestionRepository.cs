using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class QuestionRepository
    {

        public IEnumerable<Question> GetListOfQuestion()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Questions.ToList();
            }
        }

        public void AddQuestion(Question question)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Questions.Add(question);
            }
        }

        public void DeleteQuestion(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Question question = context.Questions.Find(Id);
                context.Questions.Remove(question);
            }
        }

        public void UpdateQuestion(Question question)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(question).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Question GetQuestionById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Questions.Find(Id);
            }
        }
    }
}
