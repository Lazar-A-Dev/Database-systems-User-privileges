using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class PrivZaElementeInterfejsaMapiranja : ClassMap<PrivZaElementeInterfejsa>
    {
        public PrivZaElementeInterfejsaMapiranja() {
            //Mapiranje tabele
            Table("PRIV_ZA_ELEMENTE_INTERFEJSA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.Opis, "OPIS");
            Map(x => x.Akcija, "AKCIJA");
            Map(x => x.SamoVidiTajEl, "SAMOVIDITAJEL");

            References(x => x.ElIntPripadaPriv).Column("TIPPRIVILEGIJE").LazyLoad();

            HasMany(x => x.NadPrivZaElInt).KeyColumn("PRIVZAELINTNAD").Cascade.All();

            HasMany(x => x.PodPrivZaElInt).KeyColumn("PRIVZAELINTPOD").Cascade.All();
        }
    }
}
