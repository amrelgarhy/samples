using Factory3.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3.Factories
{
    class MiniCooperFactory: IAutoFactory
    {
        public IAutoMobile CreateSportsCar()
        {
            var mini = new MiniCooper();

            mini.AddSportPackage();

            return mini;
        }

        public IAutoMobile CreateLuxuryCar()
        {
            var mini = new MiniCooper();

            mini.AddLuxuryPackage();

            return mini;
        }

        public IAutoMobile CreateEconomyCar()
        {
            return new MiniCooper();
        }
    }
}
