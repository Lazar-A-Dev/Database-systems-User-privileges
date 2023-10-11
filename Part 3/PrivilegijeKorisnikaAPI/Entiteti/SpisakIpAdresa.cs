using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class SpisakIpAdresa
    {
        public virtual int Id { get; set; }//Kod
        public virtual string IpAdrese { get; set; }
        [JsonIgnore]public virtual KorisnikIS IpPripadaKor { get; set; }
        public SpisakIpAdresa() { 
        
        }
    }
}
