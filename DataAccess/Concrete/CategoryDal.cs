using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KodlamaIoDemo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
           
            _categories = new List<Category>
            {
                new Category { Id = 1, CategoryName = "Category 1" },
                new Category { Id = 2, CategoryName = "Category 2" },
                new Category { Id = 3, CategoryName = "Category 3" }
            };
        }

        public List<Category> GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($"Kategori Adı: {category.CategoryName}");
            }

            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
            }
        }

        public void Delete(int id)
        {
            Category categoryToDelete = _categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                _categories.Remove(categoryToDelete);
            }
        }

    }
}
