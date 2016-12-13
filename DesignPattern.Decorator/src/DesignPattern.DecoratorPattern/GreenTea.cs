using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class GreenTea : Drink
    {
        public GreenTea()
        {
            _description = "GreenTea";
        }
        public override decimal cost()
        {
            return 25;
        }
    }
}
