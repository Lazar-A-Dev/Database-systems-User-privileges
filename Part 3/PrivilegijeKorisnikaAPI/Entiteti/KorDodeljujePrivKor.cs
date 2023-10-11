using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class KorDodeljujePrivKor
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }

        [JsonIgnore]
        public virtual KorisnikIS PripadaKorNadStoDodeljKorPod { get; set; }
        [JsonIgnore]
        public virtual KorisnikIS PripadaKorPodKomeDodeljKorNad { get; set; }
        [JsonIgnore]
        public virtual Privilegije PripadaPrivKojiKorNadDodeljKorPod { get; set; }

        public KorDodeljujePrivKor() { 
            
        }
    }
}
