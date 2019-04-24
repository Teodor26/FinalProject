using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class AdminRepository
    { 
        public List<Admin> GetListOfAdmin()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Admins.ToList();
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Admins.Add(admin);
            }
        }

        public void DeleteAdmin(int? Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Admin admin = context.Admins.Find(Id);
                context.Admins.Remove(admin);
            }
        }

        public void UpdateAdmin(Admin admin)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(admin).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Admin GetAdminById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Admins.Find(Id);
            }
        }
    }
}
