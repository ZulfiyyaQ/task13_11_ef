using task13_11_efstep.Models;
using task13_11_efstep.Services;

namespace task13_11_efstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            Student student1 = new Student()
            {
                Name = "Shamama",
                Surname = "Guliyeva",
                AvgPoint = 100
            };

            Student student2 = new Student()
            {
                Name = "Zuzu",
                Surname = "Qurbanova",
                AvgPoint = 95
            };


            Student student3 = new Student()
            {
                Name = "Nigar",
                Surname = "Gulmaliyeva",
                AvgPoint = 93
            };

            Student student4 = new Student()
            {
                Name = "Sebuhi",
                Surname = "Camalzade",
                AvgPoint = 76
            };

            //studentService.CreateStudent(student1);
            //studentService.CreateStudent(student2);
            //studentService.CreateStudent(student3);
            //studentService.CreateStudent(student4);
            //--------------------------------------------------------------------

            //List<Student> students = studentService.GetAllStudents();
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}
            ////------------------------------------------------------------------------

            //var searchedStudent = studentService.GetStudentById(1);
            //Console.WriteLine(searchedStudent.Name + " " + searchedStudent.Surname);

            ////-------------------------------------------------------------------------

            //studentService.DeleteStudent(4);

            ////--------------------------------------------------------------------------


        }
    }
}