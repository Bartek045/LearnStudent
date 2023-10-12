using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using LearnS.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnStudent.Areas.Admin.Controllers
{


    [Area("Admin")]
    
    public class AvatarsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AvatarsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<AvatarsUpload> objAvatarsUploadList = _unitOfWork.AvatarsUpload.GetAll().ToList();
            return View(objAvatarsUploadList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AvatarsUpload obj)
        {
           

            if (ModelState.IsValid)
            {
                _unitOfWork.AvatarsUpload.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Avatar add successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            AvatarsUpload avatarsUploadFromDb = _unitOfWork.AvatarsUpload.Get(u => u.Id == id);
            //AvatarsUpload? avatarsUploadFromDb2 = _db.AvatarsUpload.Where(u=>u.Id==id).FirstOrDefault();
            if (avatarsUploadFromDb == null)
            {
                return NotFound();
            }
            return View(avatarsUploadFromDb);
        }
        [HttpPost]
        public IActionResult Edit(AvatarsUpload obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.AvatarsUpload.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Avatar updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            AvatarsUpload avatarsUploadFromDb = _unitOfWork.AvatarsUpload.Get(u => u.Id == id);
            if (avatarsUploadFromDb == null)
            {
                return NotFound();
            }
            return View(avatarsUploadFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            AvatarsUpload obj = _unitOfWork.AvatarsUpload.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.AvatarsUpload.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Avatar deleted successfully";
            return RedirectToAction("Index");


        }
    }
}
