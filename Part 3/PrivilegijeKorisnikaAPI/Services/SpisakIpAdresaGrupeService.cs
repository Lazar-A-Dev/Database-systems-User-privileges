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
    public class SpisakIpAdresaGrupeService : ISpisakIpAdresaGrupeService
    {
        public SpisakIpAdresaGrupeService() { 
        
        }

        public SpisakIpAdresaGrupe UcitajSpisakIpAdresaGrupe(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresaGrupe ipg = s.Get<SpisakIpAdresaGrupe>(kod);

                return ipg;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciSpisakIpAdresaGrupe(GrupaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika gk = s.Load<GrupaKorisnika>(dto.Id);

                SpisakIpAdresaGrupe ipg = new SpisakIpAdresaGrupe()
                {
                    IpAdrese = "112.323.44.1"
                };

                ipg.IpPripadaGrupi = gk;
                gk.IpAdreseGrupe.Add(ipg);

                s.Save(gk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditSpisakIpAdresaGrupe(SpisakIpAdresaGrupe dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresaGrupe ipg = s.Load<SpisakIpAdresaGrupe>(dto.Id);

                ipg.IpAdrese = dto.IpAdrese;

                s.Update(ipg);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiSpisakIpAdresaGrupe(int IdIPG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakIpAdresaGrupe ipg = s.Load<SpisakIpAdresaGrupe>(IdIPG);
                s.Delete(ipg);
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
