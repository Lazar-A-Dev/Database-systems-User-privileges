using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorPosedujeProfil
    {
        public virtual int Id { get; set; }//Kod
        [JsonIgnore]
        public virtual KorisnikIS PripadaKorStoPosedujeProfil { get; set; }
        [JsonIgnore]
        public virtual Profil PripadaProfiluKojPosedujeKor { get; set; }
        public KorPosedujeProfil() { 
        
        }
    }
}
