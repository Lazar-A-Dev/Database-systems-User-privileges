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
    public class GrupaObuhvataGrupuService : IGrupaObuhvataGrupuService
    {
        public GrupaObuhvataGrupuService() { 
        
        }

        public GrupaObuhvataGrupu UcitajGrupaObuhvataGrupu(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaObuhvataGrupu gog = s.Get<GrupaObuhvataGrupu>(kod);

                return gog;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciGrupaObuhvataGrupu(GrupaObuhvataGrupuDTO2 dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika gkNad = s.Load<GrupaKorisnika>(dto.IdGrupeNad);
                GrupaKorisnika gkPod = s.Load<GrupaKorisnika>(dto.IdGrupePod);

                GrupaObuhvataGrupu gog = new GrupaObuhvataGrupu()
                {
                    
                };

                gog.PripadaNadGrupi = gkNad;
                gog.PripadaPodGrupi = gkPod;

                gkNad.NadGrupa.Add(gog);
                gkPod.PodGrupa.Add(gog);

                s.Save(gkNad);
                s.Save(gkPod);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiGrupaObuhvataGrupu(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaObuhvataGrupu gog = s.Load<GrupaObuhvataGrupu>(kod);
                s.Delete(gog);
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
