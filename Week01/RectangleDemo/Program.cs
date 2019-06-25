using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize a Rectangle object
            Rectangle r1 = new Rectangle(8, 5);
            Console.WriteLine(r1);

            //invoke the GetArea method
            Console.WriteLine($"Area: {r1.GetArea()}");
        }
    }
}
