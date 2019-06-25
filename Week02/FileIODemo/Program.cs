using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //step 1

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // WriteFile("file.txt");
            ReadFile("file.txt");
        }
        //static void WriteFile(string filename)
        //{
        //    TextWriter writer = new StreamWriter(filename); //step 2
        //    writer.WriteLine("Hello world");  //step 3
        //    writer.WriteLine("Ederson Cardoso");

        //    for (int i = 1; i <= 12; i++)
        //    {
        //        writer.WriteLine($"{i} x 2 = {i * 2}");
        //    }

        //    writer.Close(); //step 4
        //}
        static void ReadFile(string filename)
        {
            TextReader reader = new StreamReader(filename);
            string input = reader.ReadLine();
            int linenumber = 1;
            while (input != null)
            {
                Console.WriteLine($"{linenumber++,2} - {input}");
                input = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
