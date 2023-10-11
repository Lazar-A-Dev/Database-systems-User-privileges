using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class SpisakIpAdresaGrupe
    {
        public virtual int Id { get; set; }//Kod
        public virtual string IpAdrese { get; set; }

        [JsonIgnore]public virtual GrupaKorisnika IpPripadaGrupi { get; set; }
        public SpisakIpAdresaGrupe() { 
            
        }

    }
}
