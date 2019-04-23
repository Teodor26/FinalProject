using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class GroupViewModel : GroupDto
    {

        public GroupViewModel() { }

        public GroupViewModel(GroupDto groupDto)
        {
            Id = groupDto.Id;
            Name = groupDto.Name;
            BeginingDate = groupDto.BeginingDate;
            StudentsList = groupDto.StudentsList;
            TeachersList = groupDto.TeachersList;
        }
    }
}
