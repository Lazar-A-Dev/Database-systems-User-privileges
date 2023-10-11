using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IKorisnikService
    {
        KorisnikIS UcitajInfoKor(string p);
        void UbaciKor(KorisnikIS noviKorisnik);
        void EditKorisnika(KorisnikDTO dto);
        void BrisiKorisnika(string IdKor);
    }
}
