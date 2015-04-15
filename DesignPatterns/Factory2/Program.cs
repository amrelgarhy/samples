using Factory2;
using Factory2.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autofactory = LoadFactory();

            IAuto car = autofactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = "Factory2.Factories.MiniFactory";//Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
