using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IGrupaObuhvataGrupuService
    {
        GrupaObuhvataGrupu UcitajGrupaObuhvataGrupu(int kod);
        void UbaciGrupaObuhvataGrupu(GrupaObuhvataGrupuDTO2 dto);
        void BrisiGrupaObuhvataGrupu(int Id);
    }
}
