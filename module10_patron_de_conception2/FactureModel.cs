using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_patron_de_conception2
{
    public class FactureModel: IObservable<FactureModelEvent>
    {
        private FactureModelEvent m_modelEvent { get; set; }
        private List<LigneFactureModel> m_lignesFacture { get; set; }
        private List<IObserver<FactureModelEvent>> m_observateurs { get; set; }
        public decimal Total {
            get
            {
                return this.m_lignesFacture.Sum(t => t.Total);
            }
            private set {; }
        }


        public FactureModel() 
        { 
            m_lignesFacture = new List<LigneFactureModel>();
            m_observateurs = new List<IObserver<FactureModelEvent>>();
        }

        public IDisposable Subscribe(IObserver<FactureModelEvent> p_observateur)
        {
            if (m_observateurs is null)
            {
                throw new ArgumentNullException(nameof(m_observateurs));
            }
            this.m_observateurs.Add(p_observateur);
            return new UnsubscriberFactureModel(m_observateurs, p_observateur);
        }   

        public void AjouterLigneFacture(LigneFactureModel p_ligneFactureModel)
        {
            if (p_ligneFactureModel is null)
            {
                throw new ArgumentNullException(nameof(p_ligneFactureModel));
            }
            this.m_modelEvent = new FactureModelEvent(FactureModelEventType.AJOUT_LIGNE, p_ligneFactureModel);
            this.m_lignesFacture.Add(p_ligneFactureModel);
            NotifyObservers(this.m_modelEvent);
        }

        public void Nouvelle()
        {
            this.m_modelEvent = new FactureModelEvent();
            m_modelEvent.TypeEvent = FactureModelEventType.NOUVELLE;
            if(this.m_lignesFacture is not null)
            {
                this.m_lignesFacture.Clear();                
            }
            NotifyObservers(this.m_modelEvent);
        }

        public void NotifyObservers(FactureModelEvent p_valeur)
        {
            foreach (IObserver<FactureModelEvent> o in m_observateurs)
            {
                o.OnNext(p_valeur);
            }
        }
    }
}
