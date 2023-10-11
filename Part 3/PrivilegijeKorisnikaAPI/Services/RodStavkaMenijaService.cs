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
    public class RodStavkaMenijaService : IRodStavkaMenijaService
    {
        public RodStavkaMenijaService()
        {


        }

        public RodStavkaMenija UcitajRodStavkaMenija(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RodStavkaMenija rod = s.Get<RodStavkaMenija>(kod);

                return rod;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciRodStavkaMenija(RodStavkaMenijaDTO2 dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaElementeInterfejsa privNad = s.Load<PrivZaElementeInterfejsa>(dto.IdNad);
                PrivZaElementeInterfejsa privPod = s.Load<PrivZaElementeInterfejsa>(dto.IdPod);

                RodStavkaMenija rod = new RodStavkaMenija()
                {

                };

                rod.PripadaElIntNad = privNad;
                rod.PripadaElIntPod = privPod;

                privNad.NadPrivZaElInt.Add(rod);
                privPod.PodPrivZaElInt.Add(rod);

                s.Save(privNad);
                s.Save(privPod);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiRodStavkaMenija(int IdRod)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RodStavkaMenija rod = s.Load<RodStavkaMenija>(IdRod);
                s.Delete(rod);
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
