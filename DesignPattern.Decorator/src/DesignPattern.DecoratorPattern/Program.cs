using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Drink drink1 = new BlackTea();
            Console.WriteLine("Descrption:" + drink1.getDescription() + ", Cost:" +drink1.cost());

            Drink drink2 = new BlackTea();
            drink2 = new Pearl(drink2);
            drink2 = new Pudding(drink2);
            drink2 = new Latte(drink2);
            Console.WriteLine("Descrption:" + drink2.getDescription() + ", Cost:" + drink2.cost());

            Drink drink3 = new GreenTea();
            drink3 = new Pearl(drink3);
            drink3 = new Latte(drink3);
            Console.WriteLine("Descrption:" + drink3.getDescription() + ", Cost:" + drink3.cost());
            Console.ReadKey();
        }
    }
}
