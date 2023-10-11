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
    public class KorDodeljujePrivGrupiService : IKorDodeljujePrivGrupiService
    {
        public KorDodeljujePrivGrupiService() { 
        
        }
        public KorDodeljujePrivGrupi UcitajKorDodeljujePrivGrupi(int kod)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivGrupi kdpg = s.Get<KorDodeljujePrivGrupi>(kod);

                return kdpg;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UbaciKorDodeljujePrivGrupi(KorDodeljujePrivGrupiDTO2 dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>(dto.JedKorIme);
                GrupaKorisnika g = s.Load<GrupaKorisnika>(dto.JedImeGrupe);
                Privilegije p = s.Load<Privilegije>(dto.JedBrPriv);

                KorDodeljujePrivGrupi kdpg = new KorDodeljujePrivGrupi()
                {
                    DatumDodele = new DateTime(2022, 8, 12)
                };

                kdpg.PripadaKorStoDodeljGrupi = k;
                kdpg.PripadaGrupiKojojDodeljKor = g;
                kdpg.PripadaPrivKojiKorDodeljGrupi = p;

                k.KorDodeljGrupi.Add(kdpg);
                g.GrupiDodjKor.Add(kdpg);
                p.PrivKorDodeljujeGrupi.Add(kdpg);

                s.Save(k);
                s.Save(g);
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EditKorDodeljujePrivGrupi(KorDodeljujePrivGrupiDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivGrupi dkpg = s.Load<KorDodeljujePrivGrupi>(dto.Id);

                dkpg.DatumDodele = dto.DatumDodele;

                s.Update(dkpg);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiKorDodeljujePrivGrupi(int Id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorDodeljujePrivGrupi kdpg = s.Load<KorDodeljujePrivGrupi>(Id);
                s.Delete(kdpg);
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
