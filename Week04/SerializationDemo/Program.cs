using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lizard> lizards = Lizard.GetLizards();
            //SerializaOneLizard("one.json", lizards[0]);
            //SerializeAllLizards("all.json", lizards);
            //DeserializaOneLizard("one.json");
            DeserializaAllLizards("all.json");
        }
        static void SerializaOneLizard(string filename, Lizard lizard)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string output = serializer.Serialize(lizard);
            using (TextWriter writer = new StreamWriter(filename))
            {
                writer.Write(output);
            }
        }
        static void SerializeAllLizards(string filename, List<Lizard> lizards)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string output = serializer.Serialize(lizards);
                writer.Write(output);
            }
        }
        static void DeserializaOneLizard(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string input = reader.ReadToEnd();
                Lizard lizard = serializer.Deserialize<Lizard>(input);
                Console.WriteLine(lizard);
            }
        }
        static void DeserializaAllLizards(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string input = reader.ReadToEnd();
                List<Lizard> lizards = serializer.Deserialize<List<Lizard>>(input);

                int count = 1;
                foreach (Lizard lizard in lizards)
                {
                    Console.WriteLine($"{count++,-2} - {lizard}");
                }
            }
        }
    }
}
