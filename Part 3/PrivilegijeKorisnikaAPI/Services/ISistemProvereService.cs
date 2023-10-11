using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface ISistemProvereService
    {
        SistemProvere UcitajInfoSistemaProvere(int p);
        void DodajSistemProvere(KorisnikDTO dto);
        void EditSistemProvere(SistemProvereDTO dto);
        void BrisiSistemProvere(int IdSP);

    }
}
