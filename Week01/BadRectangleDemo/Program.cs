using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize a BadRectangle object
            BadRectangle r1 = new BadRectangle();
            //set the length to 8
            r1.length = 8;
            //set the width to 5
            r1.width = 5;

            //call the CalculateAndDisplayArea method
            CalculateAndDisplayArea(r1);

            //call the CreateBadRectangle method
            BadRectangle r2 = CreateBadRectangle(5, 2);
            CalculateAndDisplayArea(r2);

            //call the DescribeBadRectangle method
            DescribeBadRectangle(r1);
            DescribeBadRectangle(r2);
        }
        //create a method to calculate and display the area of an object
        static void CalculateAndDisplayArea(BadRectangle badRectangle)
        {
            int area = badRectangle.length * badRectangle.width;
            Console.WriteLine($"Area: {area}");
        }
        //write the method DescribeBadRectangle
        static void DescribeBadRectangle(BadRectangle badRectangle)
        {
            Console.WriteLine($"Width:{badRectangle.width}, length:{badRectangle.length}");
        }
        //write a method to create and return a BadRectangle
        static BadRectangle CreateBadRectangle(int length, int width)
        {
            BadRectangle badRectangle = new BadRectangle();
            badRectangle.width = width;
            badRectangle.length = length;
            return badRectangle;
        }
    }
    class BadRectangle
    {
        //data members
        public int length;
        public int width;
    }
}