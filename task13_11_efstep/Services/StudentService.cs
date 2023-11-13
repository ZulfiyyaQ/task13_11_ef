using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task13_11_efstep.DAL;
using task13_11_efstep.Exceptions;
using task13_11_efstep.Models;

namespace task13_11_efstep.Services
{
    internal class StudentService
    {
       static AppDbContext _context = new();

        public List<Student> GetAllStudents()
        {
            var Students = _context.Students.ToList();
            return Students;
        }

        public void CreateStudent(Student student)
        {

             _context.Students.Add(student);
             _context.SaveChanges();
        }
        public Student GetStudentById(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);

            if (student is null)
            {
                throw new StudentNotFoundException();
            }
            return student;

        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);

            if(student!=null)   
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            
        }
    }
}
