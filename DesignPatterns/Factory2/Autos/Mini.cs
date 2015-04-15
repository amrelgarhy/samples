using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory2
{
    public class Mini : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("The " + Name + " is running...");
        }

        public void TurnOff()
        {
            Console.WriteLine("The " + Name + " is shutting down!");
        }

        public string Name { get; private set; }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            Name = name;
        }
    }
}
