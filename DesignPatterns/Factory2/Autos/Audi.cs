using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory2
{
    public class Audi : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Audi Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Audi Turned Off");
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
