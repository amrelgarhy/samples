using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    public class BMW : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMW Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("BMW Turned Off");
        }
    }
}
