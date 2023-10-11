using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorDodeljujePrivKor
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }

        public virtual KorisnikIS PripadaKorNadStoDodeljKorPod { get; set; }
        public virtual KorisnikIS PripadaKorPodKomeDodeljKorNad { get; set; }
        public virtual Privilegije PripadaPrivKojiKorNadDodeljKorPod { get; set; }

        public KorDodeljujePrivKor() { 
            
        }
    }
}
