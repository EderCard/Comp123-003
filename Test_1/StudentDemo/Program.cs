using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //To show all student in school
            Console.WriteLine("Checking Student constructor");
            Console.WriteLine(new Student("Pershad", "Narendra", 3529));
           
            //To show all student in school
            Console.WriteLine($"\n\nAll students:");
            School school = new School("Centennial College");
            school.Show();
            
            //To show all student with last name Li in school
            string name = "Li";
            Console.WriteLine($"\n\nSudents with last name {name}");
            school.Show(name);

            //To show all student with name Yin Li in school
            string first = "Yin";
            Console.WriteLine($"\n\nSudents with name {first} {name}");
            school.Show(first, name);

            //To show all graduates in school
            Status status = Status.Graduated;
            Console.WriteLine($"\n\nStudents who are {status}");
            school.Show(status);
            
            //To show student enrolled in Game Programming
            int program = 3109;
            Console.WriteLine($"\n\nStudents in {program} program");
            school.Show(program);

            //To saving all student to a json file
            string file = "students.json";
            Console.WriteLine($"\n\nSaving students to file {file}:");
            school.Save(file);
        }
    }
}
