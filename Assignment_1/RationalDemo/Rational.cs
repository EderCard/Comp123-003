using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Assignment 1 - Rational Class
 * Ederson Cardoso - ID: 301033332
 * Andrew Cheung - ID: 300604147
 */
namespace RationalDemo
{
    class Rational
    {

        public int Denominator { get; private set; }
        public int Numerator { get; private set; }
        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public void IncreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator + Denominator * other.Numerator;
            Denominator = Denominator * other.Denominator;
        }
        public void DecreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator - Denominator * other.Numerator;
            Denominator = Denominator * other.Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
