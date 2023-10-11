using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IGrupaService 
    {
        GrupaKorisnika UcitajInfoGrupe(string p);
        GrupaKorisnika DodajGrupu(GrupaKorisnika novaGrupa);

        void EditGrupu(GrupaDTO dto);
        void BrisiGrupu(string Jedime);
    }
}
