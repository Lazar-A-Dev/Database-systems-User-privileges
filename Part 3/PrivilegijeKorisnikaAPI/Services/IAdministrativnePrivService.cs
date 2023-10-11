using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IAdministrativnePrivService
    {
        AdministrativnePriv UcitajAdministrativnePriv(int kod);
        void UbaciAdministrativnePriv(PrivilegijeDTO dto);
        void EditAdministrativnePriv(AdministrativnePrivDTO dto);
        void BrisiAdministrativnePriv(int IdAP);
    }
}
