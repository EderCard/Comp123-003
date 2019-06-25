using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    abstract class Shape
    {
        public string Name { get; } //readonly
        abstract public double Area { get; }
        public Shape(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name,-10} {Area:N2}";
        }
    }
    class Square : Shape
    {
        protected double Length { get; }
        public override double Area
        {
            get
            {
                return Length * Length;
            }
        }
        public Square(double length)
            : base("square")
        {
            Length = length;
        }
        public Square(string name, double length)
            : base(name)
        {
            Length = length;
        }
    }
    class Circle : Square
    {
        public override double Area
        {
            get
            {
                return Math.PI * Length * Length;
            }
        }
        public Circle(double length)
            : base("circle", length)
        { }
    }
    class Rectangle : Shape
    {
        protected double Height { get; }
        protected double Width { get; }
        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
        public Rectangle(double height, double width)
            : base("rectangle")
        {
            Height = height;
            Width = width;
        }
        public Rectangle(string name, double height, double width)
            : base(name)
        {
            Height = height;
            Width = width;
        }
    }

    class Ellipse : Rectangle
    {
        public override double Area
        {
            get
            {
                return Math.PI * Width * Height;
            }
        }
        public Ellipse(double height, double width)
            : base("ellipse", height, width)
        { }
    }

    class Triangle : Rectangle
    {
        public override double Area
        {
            get
            {
                return Width * Height * 0.5;
            }
        }
        public Triangle(double height, double width)
            : base("triangle", height, width)
        { }
    }
    class Diamond : Rectangle
    {
        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
        public Diamond(double height, double width)
            : base("diamond", height, width)
        { }
    }

}
