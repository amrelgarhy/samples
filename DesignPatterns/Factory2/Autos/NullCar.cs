using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory2
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
