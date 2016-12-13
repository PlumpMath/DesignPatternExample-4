using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class BlackTea : Drink
    {
        public BlackTea()
        {
            _description = "BlackTea";
        }
        public override decimal cost()
        {
            return 20;
        }
    }
}
