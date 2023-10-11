using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorDodeljujePrivGrupi
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }
        public virtual KorisnikIS PripadaKorStoDodeljGrupi { get; set; }
        public virtual GrupaKorisnika PripadaGrupiKojojDodeljKor { get; set; }
        public virtual Privilegije PripadaPrivKojiKorDodeljGrupi { get; set; }

        public KorDodeljujePrivGrupi() { 
            
        }
    }
}
