using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class SpisakIpAdresa
    {
        public virtual int Id { get; set; }//Kod
        public virtual string IpAdrese { get; set; }
        //public virtual string JedKorIme { get; set; } Strani kljuc
        public virtual KorisnikIS IpPripadaKor { get; set; }
        public SpisakIpAdresa() { 
        
        }
    }
}
