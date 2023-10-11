using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class Privilegije
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Tip { get; set; }
        [JsonIgnore]public virtual IList<KorDodeljujePrivGrupi> PrivKorDodeljujeGrupi { get; set; }
        [JsonIgnore]public virtual IList<KorDodeljujePrivKor> PrivKorDodeljujeKor { get; set; }
        [JsonIgnore]public virtual IList<PrivZaElementeInterfejsa> ElementInt { get; set; }
        [JsonIgnore]public virtual IList<PrivZaFunModApk> FunModApk { get; set; }
        [JsonIgnore]public virtual IList<AdministrativnePriv> AdminPriv { get; set; }
        public Privilegije() {

            PrivKorDodeljujeGrupi = new List<KorDodeljujePrivGrupi>();
            PrivKorDodeljujeKor = new List<KorDodeljujePrivKor>();
            ElementInt = new List<PrivZaElementeInterfejsa>();
            FunModApk = new List<PrivZaFunModApk>();
            AdminPriv = new List<AdministrativnePriv>();
        }
    }
}
