using KodlamaIoDemo.Business.Abstract;
using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entites;
using System.Collections.Generic;
using System.Linq;

namespace KodlamaIoDemo.Business.Concrete
{
    internal class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }
    }
}
