using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IPredSifreKorService
    {
        PredSifreKor UcitajPredSifreKor(int kod);
        void UbaciPredSifreKorService(SistemProvereDTO dto);
        void EditPredSifreKor(PredSifreKorDTO dto);
        void BrisiPredSifreKor(int Id);
    }
}
