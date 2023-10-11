using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class PrivZaFunModApk
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Opis { get; set; }
        [JsonIgnore]public virtual Privilegije FunModApkPripadaPriv { get; set; }
        public PrivZaFunModApk() { 
            
        }
    }
}
