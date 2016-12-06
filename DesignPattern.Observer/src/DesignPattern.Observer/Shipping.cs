using DesignPattern.Observer.DTO;
using DesignPattern.Observer.Interface;
using System;

namespace DesignPattern.Observer
{
    public class Shipping : IObserver
    {
        public Guid ShippingNo { get; set; }
        public Guid OrderId { get; set; }
        public int Amount { get; set; }

        public Shipping(ISubject subject)
        {
            subject.addObserver(this);
        }

        public void Update(OrdersDTO dto)
        {
            ShippingNo = Guid.NewGuid();
            OrderId = dto.OrderId;
            Amount = dto.Amount;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Shipping");
            Console.WriteLine("Shipping No:" + ShippingNo);
            Console.WriteLine("OrderId:" + OrderId);
            Console.WriteLine("Amount:" + Amount);
        }
    }
}
