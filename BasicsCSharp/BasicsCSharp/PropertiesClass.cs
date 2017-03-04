using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    public class PropertiesClass
    {
        public int SalaryAutomaticProperty { get; set; }

        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int ReadOnlySalary { get; }


        private int quantity;
        private int price;
        public int ReadOnlyTotalPrice { get { return quantity * price; } }
        public int PrivateSetTotalPrice { get; private set; }

        public int ReadOnlyExpressionTotalPrice => quantity * price;

        public int InlineInitProperty { get; set; } = 10;

        public int ReadOnlyInlineInitProperty { get; } = 10;
    }
}
