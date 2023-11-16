using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ISectionRepository Section { get; }

        IAvatarsUploadRepository AvatarsUpload {  get; }
        ILearningMaterialsRepository LearningMaterials { get; }

        IQuizRepository Quiz { get; }

        IQuestionRepository Question { get; }

        IApplicationUserRepository User { get; }
        IExampleTaskRepository ExampleTask { get;}

        void Save();


    }
}
