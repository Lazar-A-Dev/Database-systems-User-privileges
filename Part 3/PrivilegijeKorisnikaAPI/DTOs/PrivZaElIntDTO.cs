using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class PrivZaElIntDTO
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Opis { get; set; }
        public virtual string Akcija { get; set; }
        public virtual string SamoVidiTajEl { get; set; }//Samo vidi taj element
    }
}
