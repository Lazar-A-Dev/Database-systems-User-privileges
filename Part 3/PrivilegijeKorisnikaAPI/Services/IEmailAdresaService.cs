using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IEmailAdresaService
    {
        EmailAdresa UcitajEmailAdresa(int kod);
        void UbaciEmailAdresa(KorisnikDTO dto);
        void EditEmailAdresa(EmailAdresaDTO dto);
        void BrisiEmailAdresa(int IdEA);
    }
}
