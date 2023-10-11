using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class AdministrativnePrivMapiranja : ClassMap<AdministrativnePriv>
    {
        public AdministrativnePrivMapiranja() {
            //Mapiranje tabele
            Table("ADMINISTRATIVNE_PRIV");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.Opis, "OPIS");

            References(x => x.AdminPripadaPriv).Column("TIPPRIVILEGIJE").LazyLoad();
        }
    }
}
