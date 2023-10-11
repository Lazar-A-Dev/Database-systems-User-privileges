using PrivilegijeKorisnika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Entiteti
{
    public class EmailAdresa
    {
        public virtual int Id { get; set; }//Kod

        public virtual string Email { get; set; }
        [JsonIgnore]
        public virtual KorisnikIS EmailPripadaKor { get; set; }
        public EmailAdresa()
        {

        }

    }
}
