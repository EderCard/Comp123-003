using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(2015, "Toyota", "Corolla", 15_000, true); //15_000 just to make it easy to read
            Console.WriteLine(c);

            c = new Car(2018, "Honda", "Civic", 19_000, false);
            Console.WriteLine(c);

            Console.WriteLine(new Car(2019, "Ford", "Fusion", 32_900)); //annonymous object

        }
    }
}
