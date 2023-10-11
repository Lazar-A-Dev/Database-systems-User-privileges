using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class SpisakIpAdresaMapiranja : ClassMap<SpisakIpAdresa>
    {
        public SpisakIpAdresaMapiranja(){

            //Mapiranje tabele
            Table("SPISAK_IP_ADRESA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.IpAdrese, "IPADRESE");
            //Map(x => x.JedKorIme, "JEDKORIME");

            References(x => x.IpPripadaKor).Column("JEDKORIME").LazyLoad();
        }

    }
}
