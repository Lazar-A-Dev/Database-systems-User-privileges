using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class KorDodeljujePrivGrupiDTO
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }
    }

    public class KorDodeljujePrivGrupiDTO2 { 
        public virtual string JedKorIme { get; set; }
        public virtual string JedImeGrupe { get; set; }
        public virtual int JedBrPriv { get; set; }
        public virtual DateTime DatumDodele { get; set; }
    }
}
