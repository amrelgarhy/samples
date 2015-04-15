using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2.Factories
{
    class BMWFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var bmw = new BMW("BMW Z");

            return bmw;
        }
    }
}
