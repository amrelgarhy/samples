using Factory3.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3.Factories
{
     interface IAutoFactory
    {
        IAutoMobile CreateSportsCar();
        IAutoMobile CreateLuxuryCar();
        IAutoMobile CreateEconomyCar();
    }
}
