using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10_patron_de_conception2
{
    public class FactureModelEvent
    {
        public FactureModelEventType TypeEvent {  get; set; }
        public LigneFactureModel LigneFacture { get; set; }
        public FactureModel FactureModele { get; set; }

        public FactureModelEvent()
        {
            ;
        }

        public FactureModelEvent(FactureModelEventType typeEvent, LigneFactureModel ligneFacture)
        {
            TypeEvent = typeEvent;
            LigneFacture = ligneFacture;
        }


    }
}
