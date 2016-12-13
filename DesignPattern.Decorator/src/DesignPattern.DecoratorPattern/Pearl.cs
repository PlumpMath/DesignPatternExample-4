using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Pearl : CondimentDecorator
    {
        Drink _drink;
        public Pearl(Drink drink)
        {
            this._drink = drink;
        }

        public override decimal cost()
        {
            return 5 + _drink.cost();
        }

        public override string getDescription()
        {
            return _drink.getDescription() + "+Pearl";
        }
    }
}
