using NHibernate;
using NHibernate.Linq;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnika.Mapiranja;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public class KorisnikService : IKorisnikService
    {
        public KorisnikService() 
        {
            
        }

        public KorisnikIS UcitajInfoKor(string p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Get<KorisnikIS>(p);


                
                return k;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciKor(KorisnikIS noviKorisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS();

                k.Id = noviKorisnik.Id;
                k.DatRodj = noviKorisnik.DatRodj;
                k.JedMatBr = noviKorisnik.JedMatBr;
                k.VremePoc = noviKorisnik.VremePoc;
                k.VremeZav = noviKorisnik.VremeZav;
                k.ImeRadnogMesta = noviKorisnik.ImeRadnogMesta;
                k.FunKojuObavlja = noviKorisnik.FunKojuObavlja;
                k.BrKancelarije = noviKorisnik.BrKancelarije;
                k.SifraKor = noviKorisnik.SifraKor;
                k.Ime = noviKorisnik.Ime;
                k.ImeRod = noviKorisnik.ImeRod;
                k.Prezime = noviKorisnik.Prezime;


                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditKorisnika(KorisnikDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

                k.BrKancelarije = dto.BrojKancelarije;
                k.VremePoc = dto.VremePoc;
                k.VremeZav = dto.VremeZav;
                k.ImeRadnogMesta = dto.ImeRadnogMesta;
                k.FunKojuObavlja = dto.Funkcija;

                s.Update(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiKorisnika(string IdKor) {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>(IdKor);
                s.Delete(k);
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
