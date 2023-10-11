using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IKorDodeljujePrivGrupiService
    {
        KorDodeljujePrivGrupi UcitajKorDodeljujePrivGrupi(int kod);
        void UbaciKorDodeljujePrivGrupi(KorDodeljujePrivGrupiDTO2 dto);
        void EditKorDodeljujePrivGrupi(KorDodeljujePrivGrupiDTO dto);
        void BrisiKorDodeljujePrivGrupi(int Id);
    }
}
