using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class CondimentDecorator : Drink
    {
        public override abstract string getDescription();
    }
}
