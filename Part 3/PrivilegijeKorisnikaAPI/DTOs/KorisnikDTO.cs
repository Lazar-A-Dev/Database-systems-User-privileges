using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class KorisnikDTO
    {
        public virtual string Id { get; set; }//KorIme
        public int BrojKancelarije { get; set; }
        public string VremePoc { get; set; }
        public string VremeZav { get; set; }
        public string ImeRadnogMesta { get; set; }
        public string Funkcija { get; set; }
    }
}
