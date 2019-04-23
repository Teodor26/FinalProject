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

    public interface IUserService
    {
        List<UserDto> GetUserList();
        UserDto GetById(int Id);
        void Delete(int? Id);
        void Add(User user, string role);

    }
    public class UserService : IUserService
    {
        private UserRepository userRepository
            = new UserRepository();

        public void Add(User user, string role)
        {
            userRepository.AddUser(user, role);
        }

        public void Delete(int? Id)
        {
            userRepository.DeleteUser(Id);
        }

        public UserDto GetById(int Id)
        {
            var user = userRepository.GetUserById(Id);

            return user.ToUserDto();
        }

        public List<UserDto> GetUserList()
        {
            var userList = userRepository.GetUsersList();
            return userList.Select(x => x.ToUserDto()).ToList();
        }
    }
}
