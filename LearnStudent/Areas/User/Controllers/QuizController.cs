using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        public IActionResult Index(string section)
        {
            IEnumerable<Quiz> quizList;

            if (!string.IsNullOrEmpty(section))
            {
                quizList = _unitOfWork.Quiz.GetAll(
                    filter: q => q.Section.Title == section,
                    includeProperties: "Section,Questions"
                );
            }
            else
            {
                quizList = _unitOfWork.Quiz.GetAll(includeProperties: "Section,Questions");
            }

            ViewBag.Section = section;

            return View(quizList);
        }







        public IActionResult CheckAnswer()
        {
            return View("CheckAnswer");
        }

        [HttpPost]
        public IActionResult CheckAnswers(Dictionary<string, string> answers, string section)
        {
            int correctAnswers = 0;
            int totalQuestions = answers.Count;

            foreach (var questionId in answers.Keys)
            {
                string selectedAnswer = answers[questionId];

                if (int.TryParse(questionId.Replace("question-", ""), out int parsedQuestionId))
                {
                    var question = _unitOfWork.Question.Get(q => q.Id == parsedQuestionId, includeProperties: "Quiz");

                    if (question != null)
                    {
                        bool isCorrect = (question.IsCorrect == 1 && selectedAnswer == "1") ||
                                         (question.IsCorrect == 2 && selectedAnswer == "2") ||
                                         (question.IsCorrect == 3 && selectedAnswer == "3") ||
                                         (question.IsCorrect == 4 && selectedAnswer == "4");

                        if (isCorrect)
                        {
                            correctAnswers++;
                        }
                    }
                }
            }

            ViewBag.Section = section; 
            var result = Tuple.Create(correctAnswers, totalQuestions);
            return View("CheckAnswer", result);
        }
    }
}