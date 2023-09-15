using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace module10_patron_de_conception2
{
    public partial class fClient : Form
    {
        private FactureModel m_factureModel;

        public fClient(FactureModel factureModel)
        {
            InitializeComponent();
            m_factureModel = factureModel;
            new ObservateurFactureModel(m_factureModel, e =>
            {
                if (e.TypeEvent == FactureModelEventType.NOUVELLE)
                {
                    tbAffichageClient.Text = "Bonjour";
                }
                else if (e.TypeEvent == FactureModelEventType.AJOUT_LIGNE)
                {
                    tbAffichageClient.Text = e.LigneFacture.AfficheLigne();
                };
            });
        }
    }
}
