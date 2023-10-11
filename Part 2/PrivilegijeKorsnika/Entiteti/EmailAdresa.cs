using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class EmailAdresa
    {
        public virtual int Id { get; set; }//Kod
        //public virtual string JedKorIme { get; set; }
        public virtual string Email { get; set; }
        public virtual KorisnikIS EmailPripadaKor { get; set; }
        public EmailAdresa()
        {

        }

    }
}
