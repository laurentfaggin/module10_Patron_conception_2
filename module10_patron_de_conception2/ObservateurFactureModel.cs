using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_patron_de_conception2
{
    public class ObservateurFactureModel : IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private Action <FactureModelEvent> m_action;


        public ObservateurFactureModel(IObservable<FactureModelEvent> p_sujet, Action<FactureModelEvent> p_action)
        {
            if (p_sujet is null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }
            if (p_action is null)
            {
                throw new ArgumentNullException(nameof(p_action));
            }
            m_action = p_action;
            m_seDesabonner = p_sujet.Subscribe(this);
        }
        public void OnCompleted()
        {
            this.SeDesabonner();
        }

        public void OnError(Exception error)
        {
            throw new Exception(nameof(error));
        }

        public void SeDesabonner()
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }
        public void OnNext(FactureModelEvent p_valeur)
        {
            m_action(p_valeur);
        }
    }
}
    