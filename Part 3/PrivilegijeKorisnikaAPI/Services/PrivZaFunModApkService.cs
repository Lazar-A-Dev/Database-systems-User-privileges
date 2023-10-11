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
    public class PrivZaFunModApkService : IPrivZaFunModApkService
    {
        public PrivZaFunModApkService() { 
        
        }

        public PrivZaFunModApk UcitajInfoPrivZaFunModApk(int p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaFunModApk priv = s.Get<PrivZaFunModApk>(p);

                return priv;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciPrivZaFunModApk(PrivilegijeDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(dto.Id);

                PrivZaFunModApk pzfma = new PrivZaFunModApk()
                {
                    Opis = "Update Audit Pertitions"
                };

                pzfma.FunModApkPripadaPriv = p;
                p.FunModApk.Add(pzfma);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditPrivZaFunModApk(PrivZaFunModApkDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaFunModApk priv = s.Load<PrivZaFunModApk>(dto.Id);

                priv.Opis = dto.Opis;

                s.Update(priv);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiPrivZaFunModApk(int IdPriv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivZaFunModApk priv = s.Load<PrivZaFunModApk>(IdPriv);
                s.Delete(priv);
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
