using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class KorDodeljujePrivGrupi
    {
        public virtual int Id { get; set; }//Broj
        public virtual DateTime DatumDodele { get; set; }
        
        [JsonIgnore]
        public virtual KorisnikIS PripadaKorStoDodeljGrupi { get; set; }
        [JsonIgnore]
        public virtual GrupaKorisnika PripadaGrupiKojojDodeljKor { get; set; }
        [JsonIgnore]
        public virtual Privilegije PripadaPrivKojiKorDodeljGrupi { get; set; }

        public KorDodeljujePrivGrupi() { 
            
        }
    }
}
