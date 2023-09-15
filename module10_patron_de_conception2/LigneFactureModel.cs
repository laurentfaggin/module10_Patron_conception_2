using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_patron_de_conception2
{
    public class LigneFactureModel
    {
        public LigneFactureModel(string description, decimal quantite, decimal prix)
        {
            Description = description;
            Quantite = quantite;
            Prix = prix;
        }

        public string Description { get; private set; }
        public decimal Quantite { get; private set; }
        public decimal Prix { get; private set; }
        public decimal Total
        {
            get { return Quantite * Prix; }
            private set {; }
        }

        public string AfficheLigne()
        {
            return $"{Description} {Quantite} {Prix}";
        }
    }
}
