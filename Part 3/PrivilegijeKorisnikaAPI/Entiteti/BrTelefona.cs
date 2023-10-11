using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class BrTelefona
    {
        public virtual int Id { get; set; }//Kod
        public virtual string Telefon { get; set; }
        [JsonIgnore]
        public virtual KorisnikIS BrPripadaKor { get; set; }
        public BrTelefona(){

        }

    }
}
