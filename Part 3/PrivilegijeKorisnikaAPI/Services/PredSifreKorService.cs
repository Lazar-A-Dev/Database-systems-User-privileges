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
    public class PredSifreKorService : IPredSifreKorService
    {
        public PredSifreKorService() { 
        
        }

        public PredSifreKor UcitajPredSifreKor(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredSifreKor psk = s.Get<PredSifreKor>(kod);

                return psk;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciPredSifreKorService(SistemProvereDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Load<SistemProvere>(dto.Id);

                PredSifreKor psk = new PredSifreKor()
                {
                    PredhodnaSifra = "Marko113P"
                };

                psk.PredSifrePripadajuSistemu = sp;
                sp.PredSifre.Add(psk);

                s.Save(sp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditPredSifreKor(PredSifreKorDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredSifreKor psk = s.Load<PredSifreKor>(dto.Id);

                psk.PredhodnaSifra = "Marko223P";

                s.Update(psk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiPredSifreKor(int Id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PredSifreKor psk = s.Load<PredSifreKor>(Id);
                s.Delete(psk);
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
