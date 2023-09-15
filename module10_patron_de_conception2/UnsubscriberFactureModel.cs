using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_patron_de_conception2
{
    public class UnsubscriberFactureModel : IDisposable
    {
        private IObserver<FactureModelEvent> m_observer;
        private List<IObserver<FactureModelEvent>> m_observers;

        public UnsubscriberFactureModel(List<IObserver<FactureModelEvent>> p_observers, IObserver<FactureModelEvent> p_observer)
        {
            m_observers = p_observers;
            m_observer = p_observer;
        }
        public void Dispose()
        {
            this.m_observers.Remove(this.m_observer);
        }
    }
}
