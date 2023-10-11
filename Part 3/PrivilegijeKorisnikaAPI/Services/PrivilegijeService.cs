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
    public class PrivilegijeService : IPrivilegijeService
    {
        public Privilegije UcitajInfoPrivilegije(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije pk = s.Get<Privilegije>(kod);

                return pk;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DodajPrivilegiju(Privilegije novaPrivilegija)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = new Privilegije();

                p.Id = novaPrivilegija.Id;
                p.Tip = novaPrivilegija.Tip;


                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditPrivilegije(PrivilegijeDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(dto.Id);

                p.Tip = dto.Tip;

                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiPrivilegije(int IdPriv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Privilegije p = s.Load<Privilegije>(IdPriv);
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
