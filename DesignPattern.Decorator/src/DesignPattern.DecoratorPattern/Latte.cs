using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Latte : CondimentDecorator
    {
        Drink _drink;
        public Latte(Drink drink)
        {
            this._drink = drink;
        }

        public override decimal cost()
        {
            return 15 + _drink.cost();
        }

        public override string getDescription()
        {
            return _drink.getDescription() + "+Latte";
        }
    }
}

