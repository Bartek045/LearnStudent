using LearnS.DataAccess.Data;
using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using LearnS.Models.ViewModels;
using LearnS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace LearnStudent.Areas.User.Controllers
{
    [Area("User")]

    public class ForumController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public ForumController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }


        public async Task<IActionResult> AskQuestion(int? id)
        {
            ForumVM forumVM = new ForumVM
            {
                ForumThread = new ForumThread
                {
                    CreatedAt = DateTime.Now,
                    User = await _userManager.GetUserAsync(User)
                }
            };

            if (id != null && id != 0)
            {
                forumVM.ForumThread = _unitOfWork.ForumThread.Get(u => u.Id == id);
            }

            return View(forumVM);
        }


        public async Task<IActionResult> ViewThreadAsync(int id)
        {
            var forumThread = _unitOfWork.ForumThread.Get(u => u.Id == id, includeProperties: "ForumPosts.ForumComments,ForumPosts.User");

            if (forumThread == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);
            if (userId != null && (forumThread.ForumPosts?.All(fp => fp.UserId != userId) ?? true))
            {
                forumThread.NumberOfViews++;
                _unitOfWork.ForumThread.Update(forumThread);
                _unitOfWork.Save();
            }

            return View(forumThread);
        }





        public async Task<IActionResult> Index()
        {
            var forumThreads = await _unitOfWork.ForumThread.GetAllThreadsAsync(includeUser: true);

            foreach (var forumThread in forumThreads)
            {
                if (forumThread.ForumPosts != null && forumThread.ForumPosts.Any())
                {
                    forumThread.ForumPosts.First().NumberOfViews++;
                }
            }

            _unitOfWork.Save();

            return View(forumThreads);
        }


        [HttpPost]
        public async Task<IActionResult> AskQuestion(ForumVM forumVM)
        {
            var user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                if (forumVM.ForumThread.Id == 0)
                {

                    forumVM.ForumThread.UserId = user.Id;
                    _unitOfWork.ForumThread.Add(forumVM.ForumThread);
                    _unitOfWork.Save();


                    return RedirectToAction("Index");
                }


                var existingThread = _unitOfWork.ForumThread.Get(u => u.Id == forumVM.ForumThread.Id);

                if (existingThread == null)
                {
                    return NotFound();
                }

                existingThread.Title = forumVM.ForumThread.Title;
                existingThread.Content = forumVM.ForumThread.Content;

                _unitOfWork.ForumThread.Update(existingThread);
                _unitOfWork.Save();


                return RedirectToAction("Index");
            }


            return View(forumVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(int id, string replyContent)
        {
            var forumThread = _unitOfWork.ForumThread.Get(u => u.Id == id, includeProperties: "ForumPosts.User,ForumPosts.ForumRatings,ForumPosts.ForumComments.User");


            if (forumThread == null)
            {
                return NotFound();
            }

            var newReply = new ForumComment
            {
                Content = replyContent,
                CreatedAt = DateTime.Now,
                ForumPost = forumThread.ForumPosts.FirstOrDefault(fp => fp.UserId == _userManager.GetUserId(User)),
                UserId = _userManager.GetUserId(User)
            };

            _unitOfWork.ForumComment.Add(newReply);
            _unitOfWork.Save();

            return RedirectToAction("ViewThread", new { id = forumThread.Id });
        }

    }
}