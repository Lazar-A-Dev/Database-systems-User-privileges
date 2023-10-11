using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorObuhvataGrupu
    {
        public virtual int Id { get; set; }//Kod
        [JsonIgnore]
        public virtual KorisnikIS PripadaKorStoObuhvataGrupu { get; set; }
        [JsonIgnore]
        public virtual GrupaKorisnika PripadaGrupiKojuObuhvataKor { get; set; }
        public KorObuhvataGrupu() { 
            
        }
    }
}
