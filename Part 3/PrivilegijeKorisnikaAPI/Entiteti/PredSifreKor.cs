 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class PredSifreKor
    {
        public virtual int Id {get;set;}//Kod
        public virtual string PredhodnaSifra { get; set; }

        [JsonIgnore]
        public virtual SistemProvere PredSifrePripadajuSistemu { get; set; }
        public PredSifreKor() { 
            
        }
    }
}
