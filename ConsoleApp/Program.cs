using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hogwarts School of Witchcraft and Wizardry";
            using (var context = new UniversityContext())
            {
                var teachers = context.People.Include("Courses").Include("Department").OfType<Teacher>().ToList();
                Console.WriteLine("### HOGWARTS STAFF ###");
                foreach (var t in teachers)
                {
                    Console.WriteLine($" + {t.FirstName} {t.LastName}, {t.Qualification} at{ t.Department.Name}");
                if (t.Courses.Count > 0)
                    {
                        Console.WriteLine(" Teaching courses:");
                        foreach (var c in t.Courses) { Console.WriteLine($" -> {c.Name}"); }
                    }
                }
                var students = context.People.OfType<Student>().ToList();
                Console.WriteLine("\r\n### BEST STUDENTS ###");
                foreach (var s in students) { Console.WriteLine($@" + {s.FirstName}
                {s.LastName}{(string.IsNullOrEmpty(s.Group) ? "" : $" from {s.Group}")}"); }
            }
            Console.ReadLine();
        }
    }
}
