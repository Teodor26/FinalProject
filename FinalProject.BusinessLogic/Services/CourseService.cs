using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Services
{
    public interface ICourseService
    {
        List<CourseDto> GetCourseList();

        CourseDto GetById(int Id);

        void Update(Course course);

        void Delete(int? Id);

        void Add(Course course);
        
    }
    public class CourseService : ICourseService
    {
        CourseRepository courseRepository = new CourseRepository();

        public void Add(Course course)
        {
            courseRepository.AddCourse(course);
        }
       

        public void Delete(int? Id)
        {
            courseRepository.DeleteCourse(Id);
        }

        public CourseDto GetById(int Id)
        {

           var course = courseRepository.GetCourseById(Id);

            return course.ToCourseDto();

        }
        public void Update(Course course)
        {
            courseRepository.UpdateCourse(course);
        }

        public List<CourseDto> GetCourseList()
        {            

            var courseList = courseRepository.GetListOfCourses();

            return courseList.Select(x => x.ToCourseDto()).ToList();
        }
                
    }
}
