using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class SistemProvereMapiranja : ClassMap<SistemProvere>
    {
        public SistemProvereMapiranja() {
            Table("SISTEM_PROVERE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.SifraZadPutProm, "SIFRAZADPUTPROM");

            References(x => x.SistemProvKor).Column("JEDKORIME").LazyLoad();

            HasMany(x => x.PredSifre).KeyColumn("SPKOD").Cascade.All();
        }
    }
}
