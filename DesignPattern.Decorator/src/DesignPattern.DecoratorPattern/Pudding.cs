using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Pudding : CondimentDecorator
    {
        Drink _drink;
        public Pudding(Drink drink)
        {
            this._drink = drink;
        }

        public override decimal cost()
        {
            return 10 + _drink.cost();
        }

        public override string getDescription()
        {
            return _drink.getDescription() + "+Pudding";
        }
    }
}
