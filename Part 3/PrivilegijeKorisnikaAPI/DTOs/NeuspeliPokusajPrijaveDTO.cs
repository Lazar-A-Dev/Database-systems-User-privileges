using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class NeuspeliPokusajPrijaveDTO
    {
        public virtual int Id { get; set; }//Kod
        public virtual string PogresnaSifra { get; set; }
        public virtual string Datum { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string IpAdresa { get; set; }
        public virtual string SifraKor { get; set; }
    }
}
