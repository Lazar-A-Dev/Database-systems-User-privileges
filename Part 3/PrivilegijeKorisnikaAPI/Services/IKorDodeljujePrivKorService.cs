using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IKorDodeljujePrivKorService
    {
        KorDodeljujePrivKor UcitajKorDodeljujePrivKor(int kod);
        void UbaciKorDodeljujePrivKor(KorDodeljujePrivKorDTO2 dto);
        void EditKorDodeljujePrivKor(KorDodeljujePrivKorDTO dto);
        void BrisiKorDodeljujePrivKor(int Id);
    }
}
