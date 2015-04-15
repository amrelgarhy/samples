using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2.Factories
{
    class MiniFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            var mini = new Mini();
            mini.SetName("Mini Cooper S");

            return mini;
        }
    }
}
