using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using LearnS.Models.ViewModels;
using LearnS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearnStudent.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class QuizController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuizController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Quiz> objQuizlsList = _unitOfWork.Quiz.GetAll(includeProperties: "Section").ToList();

            return View(objQuizlsList);
        }
        public IActionResult Upsert(int? id)
        {
            QuizVM quizVM = new()
            {
                SectionList = _unitOfWork.Section.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Title,
                    Value = u.Id.ToString()
                }),
                Quiz = new Quiz()
            };
            if (id == null || id == 0)
            {
                //create
                return View(quizVM);
            }
            else
            {
                //update
                quizVM.Quiz = _unitOfWork.Quiz.Get(u => u.Id == id);
              
                return View(quizVM);
            }

        }

        [HttpPost]
        public IActionResult Upsert(QuizVM quizVM)
        {
            if (ModelState.IsValid)
            {
               
                
                if (quizVM.Quiz.Id == 0)
                {
                    _unitOfWork.Quiz.Add(quizVM.Quiz);
                }
                else
                {
                    _unitOfWork.Quiz.Update(quizVM.Quiz);
                }

                _unitOfWork.Save();
                TempData["success"] = "Quiz created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                // Przywróć listę sekcji
                quizVM.SectionList = _unitOfWork.Section.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Title,
                    Value = u.Id.ToString()
                });

                return View(quizVM);
            }
        }



        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Quiz> objQuizList = _unitOfWork.Quiz.GetAll(includeProperties: "Section").ToList();
            return Json(new { data = objQuizList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var QuizToBeDeleted = _unitOfWork.Quiz.Get(u => u.Id == id);
            if (QuizToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });

            }
            _unitOfWork.Quiz.Remove(QuizToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }


        #endregion
    }
}

