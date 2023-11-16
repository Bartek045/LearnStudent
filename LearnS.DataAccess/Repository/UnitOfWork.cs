using LearnS.DataAccess.Data;
using LearnS.DataAccess.Repository.IRepository;
using LearnS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public ISectionRepository Section { get; private set; }

        public IAvatarsUploadRepository AvatarsUpload { get; private set; }
        public ILearningMaterialsRepository LearningMaterials { get; private set; }

        public IQuizRepository Quiz { get; private set; }

        public IQuestionRepository Question { get; private set; }

        public IApplicationUserRepository User { get; private set; }
        public IExampleTaskRepository ExampleTask { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Section = new SectionRepository(_db);
            AvatarsUpload = new AvatarsUploadRepository(_db);
            LearningMaterials = new LearningMaterialsRepository(_db);
            Quiz = new QuizRepository(_db);
            Question = new QuestionRepository(_db);
            User = new ApplicationUserRepository(_db);
            ExampleTask = new ExampleTaskRepository(_db);

        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
