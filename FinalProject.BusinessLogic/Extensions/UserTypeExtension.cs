using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class UserTypeExtension
    {
        public static UserTypeDto ToUserTypeDto(this UserType userType)
        {
            if (userType == null)
                return null;

            var userTypeDto = new UserTypeDto
            {
                Id = userType.Id,
                Name = userType.Name,
                UsersList = userType.Users.Select(x => x.ToUserDto()).ToList()
            };

            return userTypeDto;
        }
    }
}
