using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface ISpisakIpAdresaGrupeService
    {
        SpisakIpAdresaGrupe UcitajSpisakIpAdresaGrupe(int kod);
        void UbaciSpisakIpAdresaGrupe(GrupaDTO dto);
        void EditSpisakIpAdresaGrupe(SpisakIpAdresaGrupe dto);
        void BrisiSpisakIpAdresaGrupe(int IdIPG);
    }
}
