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
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational();
            Console.WriteLine(r1);

            Rational r2 = new Rational(1);
            Console.WriteLine(r2);

            Rational r3 = new Rational(2, 1);
            Console.WriteLine(r3);

            Rational r4 = new Rational(1, 2);
            Console.WriteLine(r4);

            Console.Write($"{r1} + {r3} = ");
            r1.IncreaseBy(r3);
            Console.WriteLine(r1);

            Console.Write($"{r2} + {r3} = ");
            r2.IncreaseBy(r3);
            Console.WriteLine(r2);

            Console.Write($"{r3} - {r4} = ");
            r3.DecreaseBy(r4);
            Console.WriteLine(r3);

            Console.Write($"{r2} - {r1} = ");
            r2.DecreaseBy(r1);
            Console.WriteLine(r2);
        }
    }
}
