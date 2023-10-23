using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using LearnS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class QuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Question> objQuestionList = _unitOfWork.Question.GetAll(includeProperties: "Answer").ToList();

            return View(objQuestionList);
        }
    }
}
