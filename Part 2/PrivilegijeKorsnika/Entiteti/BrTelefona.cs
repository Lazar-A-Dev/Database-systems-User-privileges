using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class BrTelefona
    {
        public virtual int Id { get; set; }//Kod
        public virtual string Telefon { get; set; }
        public virtual KorisnikIS BrPripadaKor { get; set; }
        public BrTelefona(){

        }

    }
}
