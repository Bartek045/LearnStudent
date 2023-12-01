using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Identity.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
