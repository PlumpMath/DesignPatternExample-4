using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class Drink
    {
        protected string _description = "Drink";
        public virtual string getDescription()
        {
            return _description;
        }
        public abstract decimal cost();
    }
}
