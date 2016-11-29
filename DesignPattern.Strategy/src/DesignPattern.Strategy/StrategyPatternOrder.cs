using DesignPattern.Strategy.DiscountBehavior;
using DesignPattern.Strategy.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Strategy.Interface
{
    public interface IDiscountBehavior
    {
        double Discount(double Amount, List<Item> Items);
    }
}

namespace DesignPattern.Strategy.DiscountBehavior
{
    public class Discount50 : IDiscountBehavior
    {
        public double Discount(double Amount, List<Item> Items)
        {
            return Amount * 0.5;
        }
    }

    public class Discount80 : IDiscountBehavior
    {
        public double Discount(double Amount, List<Item> Items)
        {
            return Amount * 0.8;
        }
    }

    public class DiscountByItem : IDiscountBehavior
    {
        public double Discount(double Amount, List<Item> Items)
        {
            return Items.Sum( o => o.Amount) * 0.7 ;
        }
    }
}
namespace DesignPattern.Strategy
{
    public class StrategyPatternOrder
    {
        public string Id { get; set; }
        public double Amount { get; set; }
        public List<Item> Items { get; set; }
        protected IDiscountBehavior _Discount;
        public double Discount()
        {
            return _Discount.Discount(this.Amount,this.Items);
        }
        public void setDiscount(IDiscountBehavior NewDiscount)
        {
            _Discount = NewDiscount;
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public double Amount { get; set; }
    }

    public class CustomerAOrder : StrategyPatternOrder
    {
        public CustomerAOrder()
        {
            _Discount = new Discount50();
        }
    }

    public class CustomerBOrder : StrategyPatternOrder
    {
        public CustomerBOrder()
        {
            _Discount = new Discount80();
        }
    }

    public class CustomerCOrder : StrategyPatternOrder
    {
        public CustomerCOrder()
        {
            _Discount = new DiscountByItem();
        }
    }
}
