using NHibernate;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace PrivilegijeKorisnikaAPI.Services
{
    public class SistemProvereService : ISistemProvereService
    {
        public SistemProvereService()
        {

        }

        public SistemProvere UcitajInfoSistemaProvere(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Get<SistemProvere>(p);

                return sp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DodajSistemProvere(KorisnikDTO dto)
        {
            ISession s = DataLayer.GetSession();
            KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

            SistemProvere sp1 = new SistemProvere()
            {
                SifraZadPutProm = DateTime.UtcNow,
            };

            sp1.SistemProvKor = k;
            k.Provera.Add(sp1);

            s.Save(k);
            s.Flush();
            s.Close();
        }

        public void EditSistemProvere(SistemProvereDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Load<SistemProvere>(dto.Id);


                sp.SifraZadPutProm = dto.SifraZadPutProm;

                s.Update(sp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiSistemProvere(int IdSP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>(IdSP);
                s.Delete(sp);
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
