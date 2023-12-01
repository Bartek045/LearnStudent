using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.User.Controllers
{

    [Area("User")]
    public class AvatarShopController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AvatarShopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<AvatarsUpload> avatarsList = _unitOfWork.AvatarsUpload.GetAll();
            return View(avatarsList);
        }
    }
}

