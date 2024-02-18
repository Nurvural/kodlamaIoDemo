using KodlamaIoDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemo.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int id);
    }
}
