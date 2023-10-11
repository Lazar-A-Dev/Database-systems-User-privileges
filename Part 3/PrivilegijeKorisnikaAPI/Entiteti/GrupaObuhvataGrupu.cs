using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class GrupaObuhvataGrupu
    {
        public virtual int Id { get; set; }//Kod

        [JsonIgnore]
        public virtual GrupaKorisnika PripadaNadGrupi { get; set; }
        [JsonIgnore]
        public virtual GrupaKorisnika PripadaPodGrupi { get; set; }
        public GrupaObuhvataGrupu() {
            
        }
    }
}
