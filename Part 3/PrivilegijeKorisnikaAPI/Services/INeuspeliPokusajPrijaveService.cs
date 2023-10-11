using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface INeuspeliPokusajPrijaveService
    {
        NeuspeliPokusajPrijave UcitajInfoNeuspesnogPokusajaPrijave(int kod);
        void DodajNeuspeliPokusajPrijave(KorisnikDTO dto);
        void EditNeuspeliPokusajPrijave(NeuspeliPokusajPrijaveDTO dto);
        void BrisiNeuspeliPokusajPrijave(int IdNPP);
    }
}
