using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class Profil
    {
        public virtual int Id { get; set; }//RedniBr
        public virtual string BojaPozadine { get; set; }
        public virtual string SpisakElGrafInt { get; set; }
        [JsonIgnore] public virtual IList<KorPosedujeProfil> KorisniciP { get; set; }
        public Profil()
        {
            KorisniciP = new List<KorPosedujeProfil>();
        }

    }
}
