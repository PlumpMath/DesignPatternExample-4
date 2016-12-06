using DesignPattern.Observer.DTO;
using DesignPattern.Observer.Interface;
using System;

namespace DesignPattern.Observer
{
    public class Invoice : IObserver
    {
        public Guid SerialNo { get; set; }
        public Guid OrderId { get; set; }
        public int Amount { get; set; }

        public Invoice(ISubject subject)
        {
            subject.addObserver(this);
        }

        public void Update(OrdersDTO dto)
        {
            SerialNo = Guid.NewGuid();
            OrderId = dto.OrderId;
            Amount = dto.Amount;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Invoice");
            Console.WriteLine("Serial No:" + SerialNo);
            Console.WriteLine("OrderId:" + OrderId);
            Console.WriteLine("Amount:" + Amount);
        }
    }
}
