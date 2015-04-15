using Factory3.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3.Factories
{
    class BMWFactory : IAutoFactory
    {
        public Autos.IAutoMobile CreateSportsCar()
        {
            return new BMWM3();
        }

        public Autos.IAutoMobile CreateLuxuryCar()
        {
            return new BMW740i();
        }

        public Autos.IAutoMobile CreateEconomyCar()
        {
            return new BMW280i();
        }
    }
}
