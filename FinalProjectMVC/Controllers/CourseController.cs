using FinalProject.BusinessLogic.Services;
using FinalProject.EFLayer.DataModels;
using FinalProject.Models.ViewModels;
using FinalProjectMVC.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseSrvice
            = new CourseService();

        private readonly ICourseApiService courseService =
            new CourseApiService();

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> List()
        {
            //var course = _courseSrvice.GetCourseList();
            var courses = await courseService.Getlist();
            var courseViewModel = courses.Select(x => new CourseViewModel(x));
            return View(courseViewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Course course)
        {
            if(ModelState.IsValid)
            {
                _courseSrvice.Add(course);
                return View();
            }
            return View(course);         
        }

       
        public ActionResult Delete(int? Id)
        {           
            if(Id == null)
            {
                return View("Index");
            }
            _courseSrvice.Delete(Id);
            return View("Index");
        }

    }
}