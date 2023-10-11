using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class SistemProvere
    {
        public virtual int Id { get; set; }//Kod
        public virtual DateTime SifraZadPutProm { get; set; }
        [JsonIgnore]public virtual KorisnikIS SistemProvKor { get; set; }
        [JsonIgnore]public virtual IList<PredSifreKor> PredSifre { get; set; }
        public SistemProvere() {

            PredSifre = new List<PredSifreKor>();
        }
    }
}
