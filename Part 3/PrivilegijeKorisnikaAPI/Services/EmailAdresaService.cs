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
    public class EmailAdresaService : IEmailAdresaService
    {
        public EmailAdresaService() { 
        
        }

        public EmailAdresa UcitajEmailAdresa(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                EmailAdresa ea = s.Get<EmailAdresa>(kod);

                return ea;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciEmailAdresa(KorisnikDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

                EmailAdresa ea = new EmailAdresa()
                {
                    Email = "Marko.Najdanovic007@gmail.com"
                };

                ea.EmailPripadaKor = k;
                k.EAdrese.Add(ea);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditEmailAdresa(EmailAdresaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                EmailAdresa ea = s.Load<EmailAdresa>(dto.Id);

                ea.Email = dto.Email;

                s.Update(ea);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiEmailAdresa(int IdEA)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailAdresa ea = s.Load<EmailAdresa>(IdEA);
                s.Delete(ea);
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
