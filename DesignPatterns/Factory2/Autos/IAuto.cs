using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory2
{
    public interface IAuto
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }
}
