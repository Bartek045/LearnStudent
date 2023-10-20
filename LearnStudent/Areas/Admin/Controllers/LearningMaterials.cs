using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Admin.Controllers
{
    public class LearningMaterials : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
