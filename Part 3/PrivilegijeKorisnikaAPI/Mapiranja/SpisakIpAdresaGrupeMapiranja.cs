using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class SpisakIpAdresaGrupeMapiranja : ClassMap<SpisakIpAdresaGrupe>
    {
        public SpisakIpAdresaGrupeMapiranja() {
            //Mapiranje tabele
            Table("SPISAK_IP_ADRESA_GRUPE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.IpAdrese, "IPADRESE");

            References(x => x.IpPripadaGrupi).Column("JEDIMEGRUPE").LazyLoad();
        }

    }
}
