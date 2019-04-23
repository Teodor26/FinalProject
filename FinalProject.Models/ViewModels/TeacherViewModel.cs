using FinalProject.BusinessLogic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public List<TestPassingDto> TestPassingList { get; set; }

        public List<CourseDto> CoursesList { get; set; }

        public List<GroupDto> GroupsList { get; set; }


        public TeacherViewModel() { }

        public TeacherViewModel(TeacherDto teacherDto)
        {
            Id = teacherDto.Id;
            TestPassingList = teacherDto.TestPassingList;
            CoursesList = teacherDto.CoursesList;
            GroupsList = teacherDto.GroupsList;
        }
    }
}
