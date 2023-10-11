using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class ProfilDTO
    {
        public virtual int Id { get; set; }//RedniBr
        public virtual string BojaPozadine { get; set; }
        public virtual string SpisakElGrafInt { get; set; }

    }
}
