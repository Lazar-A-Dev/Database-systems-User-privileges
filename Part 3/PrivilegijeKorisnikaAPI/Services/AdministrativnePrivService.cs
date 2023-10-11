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
    public class AdministrativnePrivService : IAdministrativnePrivService
    {
        public AdministrativnePrivService() { 
        
        }

        public AdministrativnePriv UcitajAdministrativnePriv(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnePriv admin = s.Get<AdministrativnePriv>(kod);

                return admin;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciAdministrativnePriv(PrivilegijeDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(dto.Id);

                AdministrativnePriv ad = new AdministrativnePriv()
                {
                    Opis = "Manege User WIP Limits"
                };

                ad.AdminPripadaPriv = p;
                p.AdminPriv.Add(ad);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditAdministrativnePriv(AdministrativnePrivDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnePriv ap = s.Load<AdministrativnePriv>(dto.Id);

                ap.Opis = dto.Opis;

                s.Update(ap);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiAdministrativnePriv(int IdAP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnePriv ap = s.Load<AdministrativnePriv>(IdAP);
                s.Delete(ap);
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
