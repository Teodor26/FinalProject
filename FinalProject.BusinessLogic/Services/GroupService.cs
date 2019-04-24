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

    public interface IGroupService
    {
        List<GroupDto> GetGroupList();

        GroupDto GetGroupById(int Id);

        void Add(Group group, string course);

        void Delete(int? Id);
    }
    public class GroupService : IGroupService
    {
        private readonly GroupRepository groupRepository 
            = new GroupRepository();

        public void Add(Group group, string course)
        {
            groupRepository.AddGroup(group, course);
        }

        public void Delete(int? Id)
        {
            groupRepository.DeleteGroup(Id);
        }

        public GroupDto GetGroupById(int Id)
        {
            var group = groupRepository.GetGroupById(Id);

            return group.ToGroupDto();
        }

        public List<GroupDto> GetGroupList()
        {
            var groupList = groupRepository.GetListOfGroup();

            return groupList.Select(x => x.ToGroupDto()).ToList();
        }
    }
}
