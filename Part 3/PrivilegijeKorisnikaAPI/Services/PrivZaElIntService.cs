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
    public class PrivZaElIntService : IPrivZaElIntService
    {
        public PrivZaElIntService() { 
        
        }

        public PrivZaElementeInterfejsa UcitajPrivZaElInt(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaElementeInterfejsa priv = s.Get<PrivZaElementeInterfejsa>(kod);

                return priv;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciPrivZaElInt(PrivilegijeDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(dto.Id);

                PrivZaElementeInterfejsa priv = new PrivZaElementeInterfejsa()
                {
                    Opis = "Create post method",
                    Akcija = "da",
                    SamoVidiTajEl = "ne"
                };

                priv.ElIntPripadaPriv = p;
                p.ElementInt.Add(priv);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditPrivZaElInt(PrivZaElIntDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaElementeInterfejsa priv = s.Load<PrivZaElementeInterfejsa>(dto.Id);

                //br.Telefon = dto.Telefon;
                priv.Opis = dto.Opis;
                priv.Akcija = dto.Akcija;
                priv.SamoVidiTajEl = dto.SamoVidiTajEl;

                s.Update(priv);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiPrivZaElInt(int Id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivZaElementeInterfejsa priv = s.Load<PrivZaElementeInterfejsa>(Id);
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
