using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class PrivZaElementeInterfejsa
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Opis { get; set; }
        public virtual string Akcija { get; set; }
        public virtual string SamoVidiTajEl { get; set; }//Samo vidi taj element
        [JsonIgnore]public virtual Privilegije ElIntPripadaPriv { get; set; }
        [JsonIgnore]public virtual IList<RodStavkaMenija> NadPrivZaElInt { get; set; }
        [JsonIgnore]public virtual IList<RodStavkaMenija> PodPrivZaElInt { get; set; }
        public PrivZaElementeInterfejsa() {

            NadPrivZaElInt = new List<RodStavkaMenija>();
            PodPrivZaElInt = new List<RodStavkaMenija>();
        }

    }
}
