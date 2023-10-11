using NHibernate;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public class NeuspeliPokusajPrijaveService : INeuspeliPokusajPrijaveService
    {
        public NeuspeliPokusajPrijaveService() { 
            
        }

        public NeuspeliPokusajPrijave UcitajInfoNeuspesnogPokusajaPrijave(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NeuspeliPokusajPrijave npp = s.Get<NeuspeliPokusajPrijave>(kod);

                return npp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DodajNeuspeliPokusajPrijave(KorisnikDTO dto)
        {
            ISession s = DataLayer.GetSession();
            KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

            NeuspeliPokusajPrijave npp = new NeuspeliPokusajPrijave()
            {
                PogresnaSifra = "NeyfiberrJ991",
                Datum = "07-SEP-2022",
                Vreme = "09:03",
                IpAdresa = "140.250.166.0",
                SifraKor = k.SifraKor
            };

            npp.NeuspeliPokPamtiKor = k;

            k.PokusajPrijave.Add(npp);

            s.Save(k);
            s.Flush();
            s.Close();
        }

        public void EditNeuspeliPokusajPrijave(NeuspeliPokusajPrijaveDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NeuspeliPokusajPrijave npp = s.Load<NeuspeliPokusajPrijave>(dto.Id);

                npp.PogresnaSifra = dto.PogresnaSifra;
                npp.Datum = dto.Datum;
                npp.Vreme = dto.Vreme;
                npp.IpAdresa = dto.IpAdresa;
                npp.SifraKor = dto.SifraKor;


                s.Update(npp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiNeuspeliPokusajPrijave(int IdNPP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeuspeliPokusajPrijave npp = s.Load<NeuspeliPokusajPrijave>(IdNPP);
                s.Delete(npp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
