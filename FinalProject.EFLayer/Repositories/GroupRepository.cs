using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{

    public class GroupRepository
    {

        private List<Group> groupList = new List<Group>();
        private List<Group> groupEF;

        public List<Group> GetListOfGroup()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                groupEF = context.Groups
                    .Include("Course")
                    .Include("Students")
                    .Include("Teachers")
                    .ToList();

                ListInitialization();
                return groupList;
            }
        }

        public Group GetGroupById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Groups.Find(Id);
            }
        }

        public void AddGroup(Group group, string Course)
        {
            using (var context = new FinalProjectDBEntities1())
            {


                List<int> list = (context.Courses.Join(context.Groups,
                    cor => cor.Name,
                    grop => Course,
                    (cor, grop) => cor.Id)).Distinct().ToList();

                group.BeginigDate = DateTime.Now;

                try
                {
                    group.CourseId = list[0];
                }
                catch (Exception)
                {
                    group.CourseId = 1;
                }

                List<Group> query = context.Groups
                    .Where(x => x.Name == group.Name &&
                (x.IsDeleted == false || x.IsDeleted == null))
                .ToList();

                if (query.Count == 0)
                {
                    context.Groups.Add(group);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteGroup(int? Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Group group = context.Groups.Find(Id);
                group.IsDeleted = true;
                context.SaveChanges();
                groupList.Remove(group);
            }
        }

        public void UpdateGroup(Group group)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(group).State = System.Data.Entity.EntityState.Modified;
            }
        }

        private void ListInitialization()
        {
            foreach (var item in groupEF)
            {
                if (item.IsDeleted == true)
                    continue;
                else
                    groupList.Add(item);
            }

        }
    }
}
