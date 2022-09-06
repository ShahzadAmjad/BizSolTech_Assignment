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
            var model = _developerRepository.GetAllDevelopers;

            return View("AllDevelopers", model);

            //return View("AllDevelopers");
        }
    }
}
