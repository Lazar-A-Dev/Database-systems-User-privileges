using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IPrivilegijeService
    {

        Privilegije UcitajInfoPrivilegije(int kod);
        void DodajPrivilegiju(Privilegije novaPrivilegija);
        void EditPrivilegije(PrivilegijeDTO dto);
        void BrisiPrivilegije(int IdPriv);
    }
}
