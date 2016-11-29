using DesignPattern.Strategy.DiscountBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var CustA = new CustomerAOrder();
            CustA.Amount = 100;
            Console.WriteLine("Customer A Discount:" + CustA.Discount());
            CustA.setDiscount(new Discount80());
            Console.WriteLine("Customer A New Discount:" + CustA.Discount());

            var CustB = new CustomerBOrder();
            CustB.Amount = 900;
            Console.WriteLine("Customer B Discount:" + CustB.Discount());

            var CustC = new CustomerCOrder();
            CustC.Items = new List<Item>();
            CustC.Items.Add(new Item
            {
                Id = "1" ,
                Amount = 80
            });
            CustC.Items.Add(new Item
            {
                Id = "2",
                Amount = 180
            });
            Console.WriteLine("Customer C Discount:" + CustC.Discount());
            Console.ReadKey();
        }
    }
}
