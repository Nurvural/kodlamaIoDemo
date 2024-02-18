using KodlamaIoDemo.DataAccess.Abstract;
using KodlamaIoDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KodlamaIoDemo.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            
            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Nur", LastName = "Vural" },
                new Instructor { Id = 2, FirstName = "Tuba", LastName = "Günaçgün" },
                new Instructor { Id = 3, FirstName = "Emine", LastName = "Yılmaz" }
            };
        }

        public List<Instructor> GetAll()
        {
            foreach (var instructor in _instructors)
            {
                Console.WriteLine($"ID: {instructor.Id}, Adı: {instructor.FirstName}, Soyadı: {instructor.LastName}");
            }

            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
                instructorToUpdate.LastName = instructor.LastName;
            }
        }

        public void Delete(int id)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }
        }
    }
}
