using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.DTOs
{
    public class SpisakIpAdresaGrupeDTO
    {
        public virtual int Id { get; set; }//Kod
        public virtual string IpAdrese { get; set; }
    }
}
