using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Orders order = new Orders();
            Invoice invoice = new Invoice(order);
            Shipping shipping = new Shipping(order);
            order.OrderId = Guid.NewGuid();
            order.Amount = 100;
            order.Save();

            Console.ReadKey();
        }
    }
}
