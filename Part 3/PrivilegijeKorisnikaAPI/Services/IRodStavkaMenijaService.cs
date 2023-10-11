using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IRodStavkaMenijaService
    {
        RodStavkaMenija UcitajRodStavkaMenija(int kod);
        void UbaciRodStavkaMenija(RodStavkaMenijaDTO2 dto);
        void BrisiRodStavkaMenija(int IdRod);
    }
}
