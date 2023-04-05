using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            if (ModelState.IsValid == false)
            {
                return Redirect ("https://localhost:7147/home/registration");
            }

            return RedirectToAction("Summary", userProfile);
        }

        public IActionResult Summary(UserProfile userProfile)
        {
            return View(userProfile);
        }
    }
}
