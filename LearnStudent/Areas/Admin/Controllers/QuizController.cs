using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Admin.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
