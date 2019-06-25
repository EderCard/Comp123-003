using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace StudentDemo
{
    enum Status { Fulltime, Suspended, Graduated }
    class Student
    {
        private static int NEXT_ID = 321123;
        public Status Status { get; }
        public string Sin { get; }
        public string FName { get; }
        public string LName { get; }
        public int Program { get; }
        public Student(string lName, string fName, int program, Status status = Status.Fulltime)
        {
            Status = status;
            FName = fName;
            LName = lName;
            Program = program;
            Sin = NEXT_ID.ToString().Substring(0,3) + "-" + NEXT_ID.ToString().Substring(3, 3) + "-" + GenerateCheckDigit(NEXT_ID % 100);
            NEXT_ID++;
        }
        public override string ToString()
        {
            return $"{Sin} {FName} {LName} {Program} {Status}" ;
        }
        private int GenerateCheckDigit(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % 10;
        }
    }
    class School
    {
        private static List<Student> Students = new List<Student>();
        public string Name { get; }
        public School(string name)
        {
            Name = name;
            Init();
        }
        private void Init()
        {
            Students.Add(new Student("Nika", "Ilia", 3109));
            Students.Add(new Student("Lac", "Hao", 3109));
            Students.Add(new Student("Tapia", "Arben", 3109));
            Students.Add(new Student("Zouri", "Nicoletta", 3119, Status.Graduated));
            Students.Add(new Student("Li", "Yin", 3109));
            Students.Add(new Student("Khan", "Mohammed", 3109));
            Students.Add(new Student("Mavy", "Habbieh", 3109, Status.Suspended));
            Students.Add(new Student("Pershad", "Narendra", 3119, Status.Graduated));
            Students.Add(new Student("Li", "Yeseul", 3129, Status.Graduated));
            Students.Add(new Student("Khan", "Salman", 3119));
        }
        public void Show()
        {
            Console.WriteLine($"{Name}");
            int count = 1;
            foreach (Student s in Students)
            {
                Console.WriteLine($"{count++,2} {s}");
            }
        }
        public void Show(Status status)
        {
            int count = 1;
            foreach (Student s in Students)
            {
                if (s.Status == status)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void Show(string lastname)
        {
            int count = 1;
            foreach (Student s in Students)
            {
                if (s.LName == lastname)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void Show(string fisrtname, string lastname)
        {
            int count = 1;
            foreach (Student s in Students)
            {
                if (s.FName == fisrtname && s.LName == lastname)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void Show(int program)
        {
            int count = 1;
            foreach (Student s in Students)
            {
                if (s.Program == program)
                {
                    Console.WriteLine($"{count++,-2} {s}");
                }
            }
        }
        public void Save(string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string output = serializer.Serialize(Students);
                writer.Write(output);
            }
        }
    }
}
