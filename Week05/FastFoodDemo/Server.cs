using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo
{
    class Server
    {
        protected List<string> duties;
        protected double wages;
        public string Name { get; }

        public Server(string name)
        {
            Name = name;
            wages = 14.95;
            duties = new List<string>() { "mop the floor", "waiter the tables", "make burgers",
                "cleans the tables", "take orders" };
        }
        public override string ToString()
        {
            return $"Name:{Name} Wages:{wages:C}\nDuties:{string.Join(", ", duties) }";
        }
    }
    class Supervisor : Server
    {
        public Supervisor(string name)
            : base(name)
        {
            wages = 18.89;
            duties.Add("Make up schedules");
        }
    }
    class Manager : Supervisor
    {
        public Manager(string name)
            : base(name)
        {
            wages = 25.00;
            duties.Add("Take care of all");
        }
    }

}
