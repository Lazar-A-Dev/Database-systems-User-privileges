using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class SpisakIpAdresaGrupe
    {
        public virtual int Id { get; set; }//Kod
        public virtual string IpAdrese { get; set; }

        public virtual GrupaKorisnika IpPripadaGrupi { get; set; }
        public SpisakIpAdresaGrupe() { 
            
        }

    }
}
