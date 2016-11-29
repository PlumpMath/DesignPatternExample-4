using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.WithoutStrategy
{
    public abstract class Order
    {
        public string Id { get; set; }
        public double Amount { get; set; }
        public List<Item> Item { get; set;}
        public virtual double Discount()
        {
            return this.Amount * 0.9;
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public double Amount { get; set; }
    }

    public class CustomerAOrder : Order
    {
        public override double Discount()
        {
            return this.Amount * 0.8;
        }
    }
}
