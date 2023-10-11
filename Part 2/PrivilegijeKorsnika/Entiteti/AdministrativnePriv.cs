using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class AdministrativnePriv
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Opis { get; set; }
        public virtual Privilegije AdminPripadaPriv { get; set; }
        public AdministrativnePriv() { 
            
        }
    }
}
