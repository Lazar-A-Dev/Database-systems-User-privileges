using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class GrupaObuhvataGrupuMapiranja : ClassMap<GrupaObuhvataGrupu>
    {
        public GrupaObuhvataGrupuMapiranja() {
            //Mapiranje tabele
            Table("GRUPA_OBUHVATA_GRUPU");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.Assigned();


            References(x => x.PripadaNadGrupi).Column("JEDIMENADGRUPE").LazyLoad();

            References(x => x.PripadaPodGrupi).Column("JEDIMEPODGRUPE").LazyLoad();
        }
    }
}
