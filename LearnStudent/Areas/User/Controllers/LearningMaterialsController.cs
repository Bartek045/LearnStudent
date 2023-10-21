using LearnS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.User.Controllers
{
    [Area("User")]


    public class LearningMaterialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
