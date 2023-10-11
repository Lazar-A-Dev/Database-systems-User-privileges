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
    public class KorDodeljujePrivKorService : IKorDodeljujePrivKorService
    {
        public KorDodeljujePrivKorService() { 
        
        }

        public KorDodeljujePrivKor UcitajKorDodeljujePrivKor(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivKor kdpk = s.Get<KorDodeljujePrivKor>(kod);

                return kdpk;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciKorDodeljujePrivKor(KorDodeljujePrivKorDTO2 dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS kn = s.Load<KorisnikIS>(dto.IdKorNad);
                KorisnikIS kp = s.Load<KorisnikIS>(dto.IdKorPod);
                Privilegije p = s.Load<Privilegije>(dto.IdPriv);

                KorDodeljujePrivKor kdpk = new KorDodeljujePrivKor()
                {
                    //DatumDodele = new DateTime(2022, 4, 12)
                };

                kdpk.PripadaKorNadStoDodeljKorPod = kn;
                kdpk.PripadaKorPodKomeDodeljKorNad = kp;
                kdpk.PripadaPrivKojiKorNadDodeljKorPod = p;

                kn.KorNadDodeljKorPod.Add(kdpk);
                kp.KorPodKomeDodeljKorNad.Add(kdpk);
                p.PrivKorDodeljujeKor.Add(kdpk);

                s.Save(kn);
                s.Save(kp);
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditKorDodeljujePrivKor(KorDodeljujePrivKorDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivKor kdpk = s.Load<KorDodeljujePrivKor>(dto.Id);

                kdpk.DatumDodele = dto.DatumDodele;

                s.Update(kdpk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiKorDodeljujePrivKor(int Id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorDodeljujePrivKor kdpk = s.Load<KorDodeljujePrivKor>(Id);
                s.Delete(kdpk);
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
