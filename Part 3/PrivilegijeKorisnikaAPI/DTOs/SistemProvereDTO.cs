using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class SistemProvereDTO
    {
        public virtual int Id { get; set; }//Kod
        //public virtual string JedKorIme { get; set; }
        public virtual DateTime SifraZadPutProm { get; set; }
    }
}
