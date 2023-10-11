using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class RodStavkaMenija
    {
        public virtual int Id { get; set; }//Kod
        public virtual PrivZaElementeInterfejsa PripadaElIntNad { get; set; }
        public virtual PrivZaElementeInterfejsa PripadaElIntPod { get; set; }
        public RodStavkaMenija() { 
            
        }

    }
}
