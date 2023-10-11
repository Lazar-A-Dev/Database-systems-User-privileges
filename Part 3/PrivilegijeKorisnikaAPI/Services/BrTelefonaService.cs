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
    public class BrTelefonaService : IBrTelefonaService
    {
        public BrTelefonaService() { 
        
        }

        public BrTelefona UcitajBrTelefona(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BrTelefona br = s.Get<BrTelefona>(kod);

                return br;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciBrTelefona(KorisnikDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>(dto.Id);

                BrTelefona br = new BrTelefona()
                {
                    Telefon = "0671123213"
                };

                br.BrPripadaKor = k;
                k.Telefoni.Add(br);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditBrTelefona(BrTelefonaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BrTelefona br = s.Load<BrTelefona>(dto.Id);

                br.Telefon = dto.Telefon;

                s.Update(br);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiBrTelefona(int IdBr)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrTelefona br = s.Load<BrTelefona>(IdBr);
                s.Delete(br);
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
