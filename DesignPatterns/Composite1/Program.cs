using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite1
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the giant IE6 Monster and gained {0} gold!", goldForKill);

            var joe = new Person { Name = "Joe" };
            var jack = new Person { Name = "Jack" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brain = new Person { Name = "Brain" };
            var developers = new Group { Name = "Developers", Members = { joe, jack, emily } };

            var parties = new Group { Members = { developers, sophia, brain } };

            parties.Gold += goldForKill;
            parties.Stats();

            Console.ReadKey();
        }
    }
}
