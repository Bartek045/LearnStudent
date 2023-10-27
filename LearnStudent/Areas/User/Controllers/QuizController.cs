using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LearnStudent.Areas.User.Controllers
{
    [Area("User")]
    public class QuizController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuizController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Quiz> quizList = _unitOfWork.Quiz.GetAll(includeProperties: "Section");
            return View(quizList);
        }
        public IActionResult CheckAnswer()
        {
            return View("CheckAnswer");
        }

        [HttpPost]
        public IActionResult CheckAnswers(Dictionary<int, string> answers)
        {
            int correctAnswers = 0;

            foreach (var questionId in answers.Keys)
            {
                string selectedAnswer = answers[questionId];
                var question = _unitOfWork.Quiz.Get(q => q.Id == questionId);

                if (question != null && question.IsCorrect == (selectedAnswer == "true"))
                {
                    correctAnswers++;
                }

            }

           

            return View("CheckAnswer");
        }
    }
}
