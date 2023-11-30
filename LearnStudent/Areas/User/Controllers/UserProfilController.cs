using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.User.Controllers
{
    public class UserProfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
