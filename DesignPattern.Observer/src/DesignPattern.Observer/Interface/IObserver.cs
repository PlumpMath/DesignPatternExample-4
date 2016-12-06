using DesignPattern.Observer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Interface
{
    public interface IObserver
    {
        void Update(OrdersDTO dto);
    }
}
