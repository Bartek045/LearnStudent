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
    public class AnswerRepository : Repository<Answer>, IAnswerRepository
    {
        private ApplicationDbContext _db;
        public AnswerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Answer obj)
        {
            _db.Answer.Update(obj);
        }
    }
}
