using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new PropertiesClass();
            //myClass.ReadOnlyTotalPrice = 10;  // compiler error
            //myClass.ReadOnlyExpressionTotalPrice = 10; // compiler error

            Console.WriteLine(myClass.ReadOnlyInlineInitProperty);

        }
    }
}
