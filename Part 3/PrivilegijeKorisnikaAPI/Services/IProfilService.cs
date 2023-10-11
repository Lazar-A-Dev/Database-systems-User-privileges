using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IProfilService
    {
        Profil UcitajInfoProfila(int kod);
        void DodajProfil(Profil noviProfil);
        void EditProfil(ProfilDTO dto);
        void BrisiProfil(int IdProf);
    }
}
