using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Services
{
    public interface IThemeService
    {
        List<ThemeDto> GetThemeList();

        ThemeDto GetThemeById(int Id);

        void Add(Theme theme);

        void Update(Theme theme);

        void Delete(int? Id);
    }
    public class ThemeService : IThemeService
    {
        private readonly ThemeRepository _themeRepository
            = new ThemeRepository();

        public List<ThemeDto> GetThemeList()
        {
            var themeList = _themeRepository.GetListOfTheme();

            return themeList.Select(x => x.ToThemeDto()).ToList();
        }

        public void Add(Theme theme)
        {
            _themeRepository.AddTheme(theme);
        }

        public void Delete(int? Id)
        {
            _themeRepository.DeleteTheme(Id);
        }

        public void Update(Theme theme)
        {
            _themeRepository.UpdateTheme(theme);
        }

        public ThemeDto GetThemeById(int Id)
        {
            var theme = _themeRepository.GetThemeById(Id);

            return theme.ToThemeDto();
        }


    }
}
