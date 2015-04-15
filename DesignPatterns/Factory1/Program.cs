using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            //IAuto car = GetCar(carName);

            AutoFactory factory = new AutoFactory();
            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }

        static IAuto GetCar(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new BMW();
                case "mini":
                    return new Mini();
                case "audi":
                    return new Audi();
                default:
                    return new NullCar();
            }
        }
    }
}
