using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface ISpisakIpAdresaService
    {
        SpisakIpAdresa UcitajSpisakIpAdresa(int kod);
        void UbaciSpisakIpAdresa(KorisnikDTO dto);
        void EditSpisakIpAdresa(SpisakIpAdresaDTO dto);
        void BrisiSpisakIpAdresa(int IdIp);
    }
}
