using System;

namespace DesignPattern.Observer.DTO
{
    public class OrdersDTO 
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Amount { get; set; }
    }
}
