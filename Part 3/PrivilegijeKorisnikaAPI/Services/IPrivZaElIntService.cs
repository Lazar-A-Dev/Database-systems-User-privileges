using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IPrivZaElIntService
    {
        PrivZaElementeInterfejsa UcitajPrivZaElInt(int kod);
        void UbaciPrivZaElInt(PrivilegijeDTO dto);
        void EditPrivZaElInt(PrivZaElIntDTO dto);
        void BrisiPrivZaElInt(int Id);
    }
}
