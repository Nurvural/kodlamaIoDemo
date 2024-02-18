using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KodlamaIoDemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses; 

        public CourseDal()
        {
           
            _courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "Course 1", Description = "Description 1", Price = 100, CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, CourseName = "Course 2", Description = "Description 2", Price = 200, CategoryId = 2, InstructorId = 2 },
                new Course { Id = 3, CourseName = "Course 3", Description = "Description 3", Price = 300, CategoryId = 3, InstructorId = 3 }
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            foreach (var course in _courses)
            {
                Console.WriteLine($"Kurs Adı: {course.CourseName}, Açıklama: {course.Description}, Fiyat: {course.Price}");
            }

            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                // Özelliklerini güncelliyoruz
                courseToUpdate.CourseName = course.CourseName;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Price = course.Price;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }
        }
    }
}
