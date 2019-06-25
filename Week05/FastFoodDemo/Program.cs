using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Server("Milanpret"));
            Console.WriteLine();
            Console.WriteLine(new Supervisor("Anrez"));
            Console.WriteLine();
            Console.WriteLine(new Manager("Ederson Cardoso"));
        }
    }
}
