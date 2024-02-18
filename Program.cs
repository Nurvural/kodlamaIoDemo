
using KodlamaIoDemo.Business.Concrete;
using KodlamaIoDemo.DataAccess.Concrete;
using KodlamaIoDemo.Entites;
using System;

namespace KodlamaIoDemo
{
    class Program
    {
        static void Main(string[] args)
        {  
            CourseManager courseManager = new CourseManager(new CourseDal());
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            InstructorManager instructorManager = new InstructorManager( new InstructorDal());

            // Tüm kursları listeleme
            Console.WriteLine("Tüm kurslar:");
            courseManager.GetAll();

            // Yeni bir kurs ekleme
            Course newCourse = new Course { Id = 4, CourseName = "Course 4", Description = "Description 4", Price = 400, CategoryId = 4, InstructorId = 4 };
            courseManager.Add(newCourse);
            Console.WriteLine("Yeni kurs eklendi.");
            courseManager.GetAll();

            // Kurs güncelleme
            Course courseToUpdate = courseManager.GetById(1);
            courseToUpdate.Price = 150; // Fiyatı güncelliyoruz
            courseManager.Update(courseToUpdate);
            Console.WriteLine("Kurs güncellendi.");
            courseManager.GetAll();

            // Bir kursu silme
            int courseIdToDelete = 2;
            courseManager.Delete(courseIdToDelete);
            Console.WriteLine($"ID'si {courseIdToDelete} olan kurs silindi.");
            courseManager.GetAll();

            // Tüm kategorileri listeleme
            Console.WriteLine("Tüm kategoriler:");
            categoryManager.GetAll();
            // Yeni bir kategori ekleme
            Category newCategory = new Category { Id = 4, CategoryName = "Category 4" };
            categoryManager.Add(newCategory);
            Console.WriteLine("Yeni kategori eklendi.");
            categoryManager.GetAll();
            // Kategori güncelleme
            Category categoryToUpdate = categoryManager.GetById(1);
            categoryToUpdate.CategoryName = "Updated Category";
            categoryManager.Update(categoryToUpdate);
            Console.WriteLine("Kategori güncellendi.");
            categoryManager.GetAll();
            // Bir kategoriyi silme
            int categoryIdToDelete = 2;
            categoryManager.Delete(categoryIdToDelete);
            Console.WriteLine($"ID'si {categoryIdToDelete} olan kategori silindi.");
            categoryManager.GetAll();

            // Tüm eğitmenleri listeleme
            Console.WriteLine("Tüm eğitmenler:");
            instructorManager.GetAll();

            // Yeni bir eğitmen ekleme
            Instructor newInstructor = new Instructor { Id = 4, FirstName = "Sabiha", LastName = "Çapar" };
            instructorManager.Add(newInstructor);
            Console.WriteLine("Yeni eğitmen eklendi.");
            instructorManager.GetAll();

            // Eğitmen güncelleme
            Instructor instructorToUpdate = instructorManager.GetById(4);
            instructorToUpdate.FirstName = "Updated Sabiha";
            instructorToUpdate.LastName = "Updated Çapar";
            instructorManager.Update(instructorToUpdate);
            Console.WriteLine("Eğitmen güncellendi.");
            instructorManager.GetAll();

            // Bir eğitmeyi silme
            int instructorIdToDelete = 2;
            instructorManager.Delete(instructorIdToDelete);
            Console.WriteLine($"ID'si {instructorIdToDelete} olan eğitmen silindi.");
            instructorManager.GetAll();
            Console.ReadLine();
        }
    }
}
