using KodlamaIoDemo.Business.Abstract;
using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entites;
using System.Collections.Generic;

namespace KodlamaIoDemo.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }

       
    }
}
