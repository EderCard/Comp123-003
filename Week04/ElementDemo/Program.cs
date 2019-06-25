using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace ElementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atom> elements = Atom.GetAtoms();
            string filename = "elements.json";
            WriteJson(elements, filename);
            ReadJson(filename);
        }
        private static void WriteJson(List<Atom> elements, string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                writer.Write(new JavaScriptSerializer().Serialize(elements));
            }
        }
        private static void ReadJson(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                List<Atom> atoms = new JavaScriptSerializer().Deserialize<List<Atom>>(reader.ReadToEnd());
                foreach (Atom a in atoms)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
