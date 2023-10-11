using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class GrupaObuhvataGrupu
    {
        public virtual int Id { get; set; }//Kod
        public virtual GrupaKorisnika PripadaNadGrupi { get; set; }
        public virtual GrupaKorisnika PripadaPodGrupi { get; set; }
        public GrupaObuhvataGrupu()
        {

        }
    }
}
