using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class RodStavkaMenija
    {
        public virtual int Id { get; set; }//Kod
        [JsonIgnore]public virtual PrivZaElementeInterfejsa PripadaElIntNad { get; set; }
        [JsonIgnore]public virtual PrivZaElementeInterfejsa PripadaElIntPod { get; set; }
        public RodStavkaMenija() { 
            
        }

    }
}
