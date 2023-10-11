using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class GrupaObuhvataGrupuDTO
    {
        public virtual int Id { get; set; }//Kod

    }

    public class GrupaObuhvataGrupuDTO2 {
        public virtual string IdGrupeNad { get; set; }
        public virtual string IdGrupePod { get; set; }
    }
}
