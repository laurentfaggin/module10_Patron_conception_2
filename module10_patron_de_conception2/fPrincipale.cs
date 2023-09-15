namespace module10_patron_de_conception2
{
    public partial class fPrincipale : Form
    {
        private FactureModel m_factureModel;
        private fClient m_fenetreClient;
        public fPrincipale()
        {
            InitializeComponent();
            m_factureModel = new FactureModel();
            m_fenetreClient = new fClient(m_factureModel);
            new ObservateurFactureModel(m_factureModel, e =>
            {
                if (e.TypeEvent == FactureModelEventType.NOUVELLE)
                {
                    dgvLigne.DataSource = null;
                    dgvLigne.Rows.Clear();
                    tbTotal.Text = string.Empty;
                }
                else if (e.TypeEvent == FactureModelEventType.AJOUT_LIGNE)
                {
                    dgvLigne.Rows.Add(e.LigneFacture.Description, e.LigneFacture.Quantite, e.LigneFacture.Quantite, e.LigneFacture.Total);
                    tbTotal.Text = m_factureModel.Total.ToString() + " $";
                };
            });
        }     

        private void CalculTotalFacture()
        {
            decimal total = 0;
            total += dgvLigne.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value));
            
            tbTotal.Text = total.ToString();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculTotalFacture();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            this.m_factureModel.AjouterLigneFacture(new LigneFactureModel(tbDescription.Text, nudQuantite.Value, nudPrix.Value));
            tbDescription.Text = "";
            nudQuantite.Value = 0;
            nudPrix.Value = 0;
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            m_fenetreClient.Show();
        }

        private void bPayer_Click(object sender, EventArgs e)
        {
            m_factureModel.Nouvelle();
            tbDescription.Text = string.Empty;
            nudQuantite.Value = 0;
            nudPrix.Value = 0;
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}