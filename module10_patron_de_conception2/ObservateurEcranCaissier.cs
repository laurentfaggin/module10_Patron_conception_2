using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module10_patron_de_conception2
{
    public class ObservateurEcranCaissier: IObserver<FactureModelEvent>
    {
        private IDisposable m_seDesabonner;
        private DataGridView m_dbgFactureModel;
        private TextBox m_total;

        public ObservateurEcranCaissier (IObservable <FactureModelEvent> p_sujet, DataGridView p_dvgFactureModel, TextBox p_total)
        {
            if (p_sujet == null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }
            this.m_seDesabonner = p_sujet.Subscribe (this);
            this.m_dbgFactureModel = p_dvgFactureModel;
            this.m_total = p_total;
        }

        public void OnCompleted()
        {
            ;
        }

        public void OnError(Exception error)
        {
            ;
        }

        public void OnNext(FactureModelEvent value)
        {
            if (value.TypeEvent == FactureModelEventType.NOUVELLE)
            {
                m_dbgFactureModel.DataSource = null;
                m_dbgFactureModel.Rows.Clear();
            }
            else if (value.TypeEvent == FactureModelEventType.AJOUT_LIGNE)
            {
                m_dbgFactureModel.Rows.Add(value.LigneFacture.Description, value.LigneFacture.Quantite, value.LigneFacture.Quantite, value.LigneFacture.Total);
            };
        }

        public void SeDesabonner()
        {
            this.m_seDesabonner?.Dispose();
            this.m_seDesabonner = null;
        }
    }
}
