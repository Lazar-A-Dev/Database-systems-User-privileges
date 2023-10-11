using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class KorDodeljujePrivKorDTO
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }
    }

    public class KorDodeljujePrivKorDTO2 {
        public virtual string IdKorNad { get; set; }//KorImeNad
        public virtual string IdKorPod { get; set; }//KorImePod
        public virtual int IdPriv { get; set; }//BrojPrivilegije
        public virtual DateTime DatumDodele { get; set; }
    }
}
