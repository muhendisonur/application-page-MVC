using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", Repo.Applications);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if(ModelState.IsValid)
            {
                Repo.Apply(model);
                return View("Feedback", model);
            }
            else
                return View("Apply");
        }
    }
}