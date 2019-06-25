using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    //enum Days { Mon=10, Tue, Wed, Thu, Fri, Sat, Sun}
    //use enum as enum >>>> do not use values
    // enum Genre { None, Comedy, Sci_Fi, Documentary, Action, Romance, Adult }
    [Flags] //whithout this it returns the numbers and not the values
    enum Genre { None = 0, Comedy = 1, Sci_Fi = 2, Documentary = 4, Action = 8, Romance = 16, Adult = 32 }
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Days today = Days.Wed;
            Console.WriteLine(today); //prints Wed
            Console.WriteLine((int)today); //prints 2
            Console.Write("Enter a day:");
            string input = Console.ReadLine();
            Console.WriteLine(input); //prints the input
            Days d = (Days)Enum.Parse(typeof(Days), input);
            Console.WriteLine(d);  // prints the enum

            //part 2
            Genre genre = Genre.Comedy | Genre.Adult | Genre.Romance;
            Console.WriteLine(genre);
            genre = (Genre)22; // takes a binary sum of values 1+4+16
            Console.WriteLine(genre);  
            if(genre.HasFlag(Genre.Comedy)) //prints Sci_Fi, Documentary and Romance
                Console.WriteLine("is Comedy");
            else
                Console.WriteLine("is not Comedy");  //enter here because it is not comedy


        }
    }
}
