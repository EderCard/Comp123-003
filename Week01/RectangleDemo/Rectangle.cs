using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Rectangle
    {
        //data members or fields
        int length;
        int width;

        //constructor
        //similar to a method
        //name is the same as the class
        //there is no return type
        //is called automatically when an object is created
        public Rectangle(int len, int wid)
        {
            width = wid;
            length = len;
        }
        //method to return the area
        public int GetArea()
        {
            return length * width;
        }
        //the ToString method is used by Console.WriteLine
        public override string ToString()
        {
            return $"Length:{length}, width:{width}";
        }
    }
}
