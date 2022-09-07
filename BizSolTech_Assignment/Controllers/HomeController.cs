using BizSolTech_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace BizSolTech_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private IDeveloperRepository _developerRepository;
        public HomeController(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }
        [HttpGet]
        public ViewResult Index()
        {
            IEnumerable<Developer> model = _developerRepository.GetAllDevelopers();
            return View("AllDevelopers", model);
        }

        //[HttpGet]
        //public IActionResult AddPropertySchedule()
        //{
        //    PropertySchedule propertySchedule = new PropertySchedule();
        //    return PartialView("_AddPropertySchedulePartialView", propertySchedule);
        //}
        //[HttpPost]
        //public IActionResult AddPropertySchedule(PropertySchedule propertySchedule)
        //{

        //}

        [HttpGet]
        public IActionResult AddDeveloper()
        {
            Developer developer = new Developer();
            return PartialView("_AddDeveloperPartialView", developer);
        }

        [HttpPost]
        public IActionResult AddDeveloper(Developer developer)
        {
           // if(ModelState.IsValid)
            {
                _developerRepository.AddDeveloper(developer);
            }

            IEnumerable<Developer> model = _developerRepository.GetAllDevelopers();
            return View("AllDevelopers", model);
        }
    }
}
