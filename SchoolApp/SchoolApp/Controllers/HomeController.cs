using Microsoft.AspNetCore.Mvc;
using SchoolApp.Entities;
using SchoolApp.Models;
using System.Diagnostics;

namespace SchoolApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DatabaseContext _databaseContext;
        public HomeController(ILogger<HomeController> logger, DatabaseContext databaseContext)
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> model = _databaseContext.Students.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Student students)
        {

            return View();
        }
        public IActionResult Edit(int id)
        {
            Student student = _databaseContext.Students.Where(x => x.Id == id).FirstOrDefault();
            StudentEditViewModel model = new StudentEditViewModel();

            model.FirstName = student.FirstName;
            model.LastName = student.LastName;
            model.Department = student.Department;
            model.Hobbys = student.Hobbys;
            model.MainTeacher = student.MainTeacher;
            model.GuideTeacher = student.GuideTeacher;

            return View(model);
        }       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}