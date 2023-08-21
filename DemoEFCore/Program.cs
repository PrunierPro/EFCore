using DemoEFCore.Data;
using DemoEFCore.Models;

namespace DemoEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();

            Student student = new Student()
            {
                FirstName = "John",
                LastName = "Doe",
                Phone = "0607080910",
                Email = "email@email.com"
            };

            //context.Students.Add(student);
            //context.SaveChanges();

            List<Student> students = context.Students.ToList();
            foreach(Student s in students)
            {
                Console.WriteLine($"{s.Id}, {s.FirstName}, {s.LastName}");
            }

            Student student1 = context.Students.Find(1);
            Console.WriteLine($"{student1.Id}, {student1.FirstName}, {student1.LastName}");
        }
    }
}