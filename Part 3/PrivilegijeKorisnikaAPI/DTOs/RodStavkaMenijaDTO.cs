using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class RodStavkaMenijaDTO
    {
        public virtual int Id { get; set; }//Kod
    }

    public class RodStavkaMenijaDTO2 { 
        public virtual int IdNad { get; set; }
        public virtual int IdPod { get; set; }
    }
}
