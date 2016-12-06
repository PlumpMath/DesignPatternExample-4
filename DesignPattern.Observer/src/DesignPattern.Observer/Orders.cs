using DesignPattern.Observer.DTO;
using DesignPattern.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Orders : ISubject
    {
        private IList<IObserver> _observsers;
        private OrdersDTO _ordersDto;
        public Guid OrderId { get; set; }
        public int Amount { get; set; }

        public Orders()
        {
            _observsers = new List<IObserver>();
        }

        public void Save()
        {
            _ordersDto = new OrdersDTO();
            _ordersDto.OrderId = OrderId;
            _ordersDto.OrderDate = DateTime.Now;
            _ordersDto.Amount = Amount;
            notifyObserver();
        }

        public void addObserver(IObserver o)
        {
            _observsers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            if(_observsers.IndexOf(o) >= 0)
                _observsers.Remove(o);
        }

        public void notifyObserver()
        {
            foreach(var observer in _observsers)
            {
                observer.Update(_ordersDto);
            }
        }
    }
}
