using NHibernate;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public class GrupaService : IGrupaService
    {
        public GrupaKorisnika UcitajInfoGrupe(string p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Get<GrupaKorisnika>(p);

                return g;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public GrupaKorisnika DodajGrupu(GrupaKorisnika novaGrupa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = new GrupaKorisnika();

                g.Id = novaGrupa.Id;
                g.KratakOpis = novaGrupa.KratakOpis;
                g.DatumKreiranja = novaGrupa.DatumKreiranja;
                g.VremePocPer = novaGrupa.VremePocPer;
                g.VremeZavPer = novaGrupa.VremeZavPer;


                s.Save(g);
                s.Flush();
                s.Close();


                return g;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EditGrupu(GrupaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Load<GrupaKorisnika>(dto.Id);

                g.KratakOpis = dto.KratakOpis;

                s.Update(g);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BrisiGrupu(string Jedime)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaKorisnika g = s.Load<GrupaKorisnika>(Jedime);
                s.Delete(g);
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
