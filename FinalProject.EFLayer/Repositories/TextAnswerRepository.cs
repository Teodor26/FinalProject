﻿using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class TextAnswerRepository
    {
        public IEnumerable<TextAnswer> GetListOfTextAnswer()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.TextAnswers.ToList();
            }
        }

        public void AddTextAnswer(TextAnswer textAnswer)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.TextAnswers.Add(textAnswer);
            }
        }

        public void DeleteTextAnswer(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                TextAnswer textanswer = context.TextAnswers.Find(Id);
                context.TextAnswers.Remove(textanswer);
            }
        }

        public TextAnswer GetTextAnswerById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.TextAnswers.Find(Id);
            }
        }
    }
}