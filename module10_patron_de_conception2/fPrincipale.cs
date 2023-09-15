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
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    textBoxTotal.Text = string.Empty;
                }
                else if (e.TypeEvent == FactureModelEventType.AJOUT_LIGNE)
                {
                    dataGridView2.Rows.Add(e.LigneFacture.Description, e.LigneFacture.Quantite, e.LigneFacture.Quantite, e.LigneFacture.Total);
                    textBoxTotal.Text = m_factureModel.Total.ToString() + " $";
                };
            });
        }     

        private void CalculTotalFacture()
        {
            decimal total = 0;
            total += dataGridView2.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value));
            
            textBoxTotal.Text = total.ToString();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculTotalFacture();
        }

        private void bSimuler_Click(object sender, EventArgs e)
        {
            this.m_factureModel.AjouterLigneFacture(new LigneFactureModel(textBoxDescription.Text, upQuantite.Value, upPrix.Value));
            textBoxDescription.Text = "";
            upQuantite.Value = 0;
            upPrix.Value = 0;
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            m_fenetreClient.Show();
        }

        private void bPayer_Click(object sender, EventArgs e)
        {
            m_factureModel.Nouvelle();
            textBoxDescription.Text = string.Empty;
            upQuantite.Value = 0;
            upPrix.Value = 0;
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}