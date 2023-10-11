using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class RodStavkaMenijaMapiranja : ClassMap<RodStavkaMenija>
    {
        public RodStavkaMenijaMapiranja() {
            //Mapiranje tabele
            Table("ROD_STAVKA_MENIJA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            References(x => x.PripadaElIntNad).Column("PRIVZAELINTNAD").LazyLoad();

            References(x => x.PripadaElIntPod).Column("PRIVZAELINTPOD").LazyLoad();
        }
    }
}
