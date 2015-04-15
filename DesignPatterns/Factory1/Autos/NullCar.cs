using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory1
{
    public class NullCar : IAuto
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}
