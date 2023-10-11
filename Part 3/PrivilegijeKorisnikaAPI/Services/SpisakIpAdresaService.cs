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
    public class SpisakIpAdresaService : ISpisakIpAdresaService
    {
        public SpisakIpAdresaService()
        {

        }

        public SpisakIpAdresa UcitajSpisakIpAdresa(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresa ip = s.Get<SpisakIpAdresa>(kod);

                return ip;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciSpisakIpAdresa(KorisnikDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

                SpisakIpAdresa ip = new SpisakIpAdresa()
                {
                    IpAdrese = "110.22.34.12.2"
                };

                ip.IpPripadaKor = k;
                k.IpAdrese.Add(ip);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditSpisakIpAdresa(SpisakIpAdresaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresa ip = s.Load<SpisakIpAdresa>(dto.Id);

                ip.IpAdrese = dto.IpAdrese;
                
                s.Update(ip);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiSpisakIpAdresa(int IdIp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakIpAdresa ip = s.Load<SpisakIpAdresa>(IdIp);
                s.Delete(ip);
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
