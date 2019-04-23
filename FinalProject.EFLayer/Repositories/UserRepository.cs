﻿using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class UserRepository
    {
        private List<User> userList = new List<User>();
        private List<User> usersEF;
        public List<User> GetUsersList()
        {
            var context = new FinalProjectDBEntities1();
            //using (var context = new FinalProjectDBEntities1())
            //{

            usersEF = context.Users
                    .Include("Teachers")
                    .Include("Admins")
                    .Include("Students")
                    .Include("UserType")
                    .ToList();


            ListInitialization();
            return userList;
            // }
        }

        public void AddUser(User user, string role)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                List<int> list = (context.UserTypes.Join(context.Users,
                   us => us.Name,
                   type => role,
                   (us, type) => us.Id)).Distinct().ToList();


                user.IsDeleted = false;
                try
                {
                    user.UserTypeId = list[0];

                }
                catch
                {
                    user.UserTypeId = 1;
                }

                List<User> query = context.Users
                   .Where(x => x.FirstName == user.FirstName && x.LastName == user.LastName 
                   && (x.IsDeleted == false || x.IsDeleted == null) )
               .ToList();
                if (query.Count == 0)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                   
            }
        }

        public void DeleteUser(int? Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                User user = context.Users.Find(Id);
                user.IsDeleted = true;
                context.SaveChanges();
                userList.Remove(user);
            }
        }

        public User GetUserById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Users.Find(Id);

            }
        }


        private void ListInitialization()
        {
            foreach (var item in usersEF)
            {
                if (item.IsDeleted == true)
                    continue;
                else
                    userList.Add(item);
            }

        }
    }
}
