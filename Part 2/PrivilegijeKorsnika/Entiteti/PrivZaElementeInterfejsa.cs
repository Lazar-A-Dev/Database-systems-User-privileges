using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class PrivZaElementeInterfejsa
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Opis { get; set; }
        public virtual string Akcija { get; set; }
        public virtual string SamoVidiTajEl { get; set; }//Samo vidi taj element
        public virtual Privilegije ElIntPripadaPriv { get; set; }
        public virtual IList<RodStavkaMenija> NadPrivZaElInt { get; set; }
        public virtual IList<RodStavkaMenija> PodPrivZaElInt { get; set; }
        public PrivZaElementeInterfejsa() {

            NadPrivZaElInt = new List<RodStavkaMenija>();
            PodPrivZaElInt = new List<RodStavkaMenija>();
        }

    }
}
