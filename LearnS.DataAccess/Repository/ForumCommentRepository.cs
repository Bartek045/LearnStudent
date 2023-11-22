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
    public class ForumCommentRepository : Repository<ForumComment>, IForumCommentRepository
    {
        private ApplicationDbContext _db;

        public ForumCommentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ForumComment obj)
        {
            _db.ForumComments.Update(obj);
        }
    }
}
