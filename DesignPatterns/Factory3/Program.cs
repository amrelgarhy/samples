using Factory3.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory3
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory autofactory = LoadFactory();

            PrintHeader("SPORT CAR");
            var car = autofactory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("LUXURY CAR");
            car = autofactory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            PrintHeader("ECONOMY CAR");
            car = autofactory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = "Factory2.Factories.MiniFactory";//Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }

        static void PrintHeader(string header)
        {
            Console.WriteLine(string.Format("**********{0}**********", header));
        }
    }
}
