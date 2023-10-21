using LearnS.DataAccess.Data;
using LearnS.DataAccess.Repository.IRepository;
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
        public ILearningMaterialsRepository LearningMaterials {  get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Section = new SectionRepository(_db);
            AvatarsUpload = new AvatarsUploadRepository(_db);
            LearningMaterials = new LearningMaterialsRepository(_db);
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
