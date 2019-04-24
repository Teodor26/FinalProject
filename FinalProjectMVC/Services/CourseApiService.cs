using FinalProject.BusinessLogic.Dto;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FinalProjectMVC.Services
{
    public interface ICourseApiService
    {
        Task<List<CourseDto>> Getlist();

    }
    public class CourseApiService : ICourseApiService
    {
        private readonly CourseRepository courseRepository
            = new CourseRepository();

        public async Task<List<CourseDto>> Getlist()
        {
            HttpClient client = new HttpClient();

            string apiEndpoint = Properties.Settings.Default.ApiEndpoint;

            client.BaseAddress = new Uri("http://localhost:52470/api/Course");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var list = courseRepository.GetListOfCourses();

            List<CourseDto> courseList = list.Select(x => x.ToCourseDto()).ToList();

            var response = await client.GetAsync("courseList");

            if (response.IsSuccessStatusCode)
            {
                courseList = await response.Content.ReadAsAsync<List<CourseDto>>();
            }
            return courseList;
        }
    }
}