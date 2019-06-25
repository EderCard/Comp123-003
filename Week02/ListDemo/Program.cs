using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListStringDemo();
        }
        static void ListStringDemo()
        {
            //Creating a list with five strings
            List<string> pms = new List<string>() { "Trudeau", "Harper", "Martin", "Chretien", "Campbell" };
            PrintStringList(pms);
            string pm = "Mulroney";
            Console.WriteLine($"\nAdding {pm} to list");
            pms.Add(pm);
            PrintStringList(pms);

            pm = "King";
            int position = 3;
            Console.WriteLine($"\nInserting {pm} @{position} to list");
            pms.Insert(position, pm);
            PrintStringList(pms);

            Console.WriteLine($"\nRemoving {pm} from list");
            pms.Remove(pm);
            PrintStringList(pms);

            //loop to remove all names that starts with "M"
            pm = "M";
            Console.WriteLine($"\nRemoving names starting with {pm}");
            for (int i = 0; i < pms.Count; i++)
            {
                if (pms[i].StartsWith(pm))
                {
                    pms.RemoveAt(i);
                }
            }
            PrintStringList(pms);
        }
        static void PrintStringList(List<string> list)
        {
            foreach (string pm in list)
            {
                Console.Write(pm + ", ");
            }
        }
    }
}
