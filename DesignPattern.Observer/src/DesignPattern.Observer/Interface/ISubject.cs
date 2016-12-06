using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Interface
{
    public interface ISubject
    {
        void addObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObserver();
    }
}
