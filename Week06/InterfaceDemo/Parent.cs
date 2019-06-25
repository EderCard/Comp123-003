using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace InterfaceDemo
{
    interface IDrawable
    {
        void Draw(Graphics g);
    }
    interface IWriteable
    {
        void Write(TextWriter writer);
    }
    abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }
        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            Color = color;
            Filled = filled;
            Rectangle = rectangle;
        }
        public abstract void Draw(Graphics g);
    }
    class DrawableRectangle : Parent, IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        { }
        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);

            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color.ToKnownColor()} rectangle {(Filled ? "filled" : "border")} {Rectangle}");
        }
    }

    class DrawableEllipse : Parent, IDrawable
    { 
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        {
        }
        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }
    }
    class DrawableLine: IDrawable, IWriteable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point End { get; }
        public DrawableLine(Color color, Point start, Point end)
        {
            Color = color;
            Start = start;
            End = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawLine(pen, Start, End);
        }
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"{Color} Start:{Start} End:{End}");
        }
    }
    class DrawableBezier : IDrawable, IWriteable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point First { get; }
        protected Point Second { get; }
        protected Point End { get; }

        public DrawableBezier(Color color, Point start, Point end, Point first, Point second)
        {
            Color = color;
            Start = start;
            End = end;
            First = first;
            Second = second;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawBezier(pen, Start, End, First, Second);
        }
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"{Color} Start:{Start} First:{First} Second:{Second} End:{End}");
        }
    }
    class DrawableArc : Parent, IWriteable
    {
        protected float Start { get; }
        protected float End { get; }

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end)
            : base(color, filled, rectangle)
        {
            Start = start;
            End = end;
        }
        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                Brush FillPie = new SolidBrush(Color.Black);
                g.FillPie(FillPie, Rectangle, Start, End);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawArc(pen, Rectangle, Start, End);
            }

        }
        public void Write(TextWriter writer)
        {
            Console.WriteLine($"{Color} Filled:{Filled} Start:{Start} End:{End}");
        }
    }
}