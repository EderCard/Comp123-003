using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(2019, 5, 8);
            Console.WriteLine(d);

            int days = 1, months = 6, years = 2;
            d.Add(days);
            Console.WriteLine($"Adding {days} days");
            Console.WriteLine(d);

            days = 28;
            d.Add(months, days);
            Console.WriteLine($"Adding {months} months and {days} days");
            Console.WriteLine(d);

            Date d1 = new Date(years, months, days);
            Console.WriteLine($"Adding {years} years, {months} months and {days} days");
            d.Add(d1);
            Console.WriteLine(d);
        }
    }
}
