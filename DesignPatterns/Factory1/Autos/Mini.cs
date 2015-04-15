using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    public class Mini : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Mini Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Mini Turned Off");
        }
    }
}
