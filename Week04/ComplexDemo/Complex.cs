using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {
        //autoimplemented properties
        public int Real { get; private set; }
        public int Imaginary { get; private set; }
        //computed properties
        public double Modulus
        {
            get { return Math.Sqrt(Real * Real + Imaginary * Imaginary); }
        }
        public double Argument
        {
            get { return Math.Atan((double)Real / Imaginary); }
        }
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"<{Real}, {Imaginary}>";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == lhs.Imaginary;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary;
        }
    }
}
