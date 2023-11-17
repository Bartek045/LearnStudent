using LearnS.DataAccess.Data;
using LearnS.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnStudent.Areas.User.Controllers
{
    [Area("User")]
    public class ForumController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ForumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: ForumThread
        public async Task<IActionResult> Index()
        {
            var forumThreads = await _unitOfWork.ForumThread.GetAllThreadsAsync();
            return View(forumThreads);
        }
    }
}