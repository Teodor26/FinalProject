﻿using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.ViewModels
{
    public class CourseViewModel
    {
        public string Name { get; set; }

        public List<TeacherDto> teachersList { get; set; }

        public List<ModuleDto> modulesList { get; set; }

        public List<GroupDto> groupsList { get; set; }

        public CourseViewModel() { }

        public CourseViewModel(CourseDto courseDto)
        {
            Name = courseDto.Name;
            teachersList = courseDto.TeachersList;
            modulesList = courseDto.ModulesList;
            groupsList = courseDto.GroupsList;
        }
    }
}
