using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Admin.Controllers
{
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
