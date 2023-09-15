using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module10_patron_de_conception2
{
    public class ObservateurEcranClient : IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private FactureModel m_factureModel;
        private TextBox m_affichage;

        public ObservateurEcranClient(IObservable<FactureModelEvent> p_sujet, TextBox p_affichage)
        {
            if (p_sujet == null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }
            this.m_seDesabonner = p_sujet.Subscribe(this);
        }
        public void OnCompleted()
        {
            this.SeDesabonner();
        }

        public void OnError(Exception error)
        {
           throw new Exception();
        }

        public void OnNext(FactureModelEvent value)
        {
            if (value.TypeEvent == FactureModelEventType.NOUVELLE)
            {
                m_affichage.Text = "Bienvenue!";
            }
            else if (value.TypeEvent == FactureModelEventType.AJOUT_LIGNE)
            {
               
                m_affichage.Text = value.LigneFacture.AfficheLigne();
            };
        }

        public void SeDesabonner()
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }
    }
}
