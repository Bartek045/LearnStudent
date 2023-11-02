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
            foreach (var answer in answers)
            {
                System.Diagnostics.Debug.WriteLine($"Question ID: {answer.Key}, Selected Answer: {answer.Value}");
            }
            int correctAnswers = 0;

            foreach (var questionId in answers.Keys)
            {
                string selectedAnswer = answers[questionId];
                var question = _unitOfWork.Quiz.Get(q => q.Id == questionId);

                if (question != null)
                {
                    bool isCorrect = (question.CorrectAnswer == 1 && selectedAnswer == "AnswerI") ||
                                     (question.CorrectAnswer == 2 && selectedAnswer == "AnswerII") ||
                                     (question.CorrectAnswer == 3 && selectedAnswer == "AnswerIII") ||
                                     (question.CorrectAnswer == 4 && selectedAnswer == "AnswerIV");

                    // Log the result of the comparison
                    System.Diagnostics.Debug.WriteLine($"Question ID: {questionId}, Is Correct: {isCorrect}");

                    if (isCorrect)
                    {
                        correctAnswers++;
                    }
                }
            }




            // Pass the number of correct answers to the view
            return View("CheckAnswer", correctAnswers);


        }
    }
}
