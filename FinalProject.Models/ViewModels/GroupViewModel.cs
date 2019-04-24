using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BeginingDate { get; set; }

        public List<StudentDto> StudentsList { get; set; }

        public List<TeacherDto> TeachersList { get; set; }

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
