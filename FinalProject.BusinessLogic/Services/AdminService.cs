using FinalProject.BusinessLogic.Dto;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.DataLayer.Repositories;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Services
{
    public interface IAdminService
    {
        List<AdminDto> GetAdminList();

        AdminDto GetAdminById(int Id);

        void Add(Admin admin);

        void Update(Admin admin);

        void Delete(int? Id);
    }

    public class AdminService : IAdminService
    {
        private readonly AdminRepository _adminRepository
                    = new AdminRepository();

        public void Add(Admin admin)
        {
            _adminRepository.AddAdmin(admin);
        }

        public void Delete(int? Id)
        {
            _adminRepository.DeleteAdmin(Id);
        }

        public AdminDto GetAdminById(int Id)
        {
            var admin = _adminRepository.GetAdminById(Id);

            return admin.ToAdminDto();
        }

        public void Update(Admin admin)
        {
            _adminRepository.UpdateAdmin(admin);
        }

        public List<AdminDto> GetAdminList()
        {
            var adminList = _adminRepository.GetListOfAdmin();

            return adminList.Select(x => x.ToAdminDto()).ToList();
        }
    }
}
