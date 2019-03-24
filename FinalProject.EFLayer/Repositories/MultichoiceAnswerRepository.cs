﻿using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class MultichoiceAnswerRepository
    {
        public IEnumerable<MultichoiceAnswer> GetListOfMultiChoiceAnswers()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.MultichoiceAnswers.ToList();
            }
        }

        public void AddMultiChoiceAnswers(MultichoiceAnswer multiChoiseAnswer)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.MultichoiceAnswers.Add(multiChoiseAnswer);
            }
        }

        public void DeleteAddMultiChoiceAnswers(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                MultichoiceAnswer multiChoiceAnswer = context.MultichoiceAnswers.Find(Id);
                context.MultichoiceAnswers.Remove(multiChoiceAnswer);
            }
        }

        public MultichoiceAnswer GetMultiChoiceAnswerById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.MultichoiceAnswers.Find(Id);
            }
        }
    }
}
