using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet a = new Pet("Garfiled", 5, "fat cat");
            Console.WriteLine(a);
            a.SetOwner("John");
            Console.WriteLine(a);
            a.Train();
            Console.WriteLine(a);
        }
    }
}
