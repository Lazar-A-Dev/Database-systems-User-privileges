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
    public class ProfilService : IProfilService
    {
        public Profil UcitajInfoProfila(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Get<Profil>(kod);

                return p;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DodajProfil(Profil noviProfil)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = new Profil();

                p.Id = noviProfil.Id;
                p.BojaPozadine = noviProfil.BojaPozadine;
                p.SpisakElGrafInt = noviProfil.SpisakElGrafInt;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EditProfil(ProfilDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Load<Profil>(dto.Id);

                p.BojaPozadine = dto.BojaPozadine;
                p.SpisakElGrafInt = dto.SpisakElGrafInt;

                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiProfil(int IdProf)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Profil p = s.Load<Profil>(IdProf);
                s.Delete(p);
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
