using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class ThemeRepository
    {
        public IEnumerable<Theme> GetListOfTheme()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Themes.ToList();
            }
        }

        public void AddTheme(Theme theme)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Themes.Add(theme);
            }
        }

        public void DeleteTheme(int? Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Theme theme = context.Themes.Find(Id);
                context.Themes.Remove(theme);
            }
        }

        public void UpdateTheme(Theme theme)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Entry(theme).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public Theme GetThemeById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Themes.Find(Id);
            }
        }
    }
}
