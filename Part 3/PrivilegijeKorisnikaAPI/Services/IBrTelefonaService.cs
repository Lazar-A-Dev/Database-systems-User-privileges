using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IBrTelefonaService
    {
        BrTelefona UcitajBrTelefona(int kod);
        void UbaciBrTelefona(KorisnikDTO dto);
        void EditBrTelefona(BrTelefonaDTO dto);
        void BrisiBrTelefona(int IdBr);
    }
}
