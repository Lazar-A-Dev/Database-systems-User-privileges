using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorObuhvataGrupuMapiranja : ClassMap<KorObuhvataGrupu>
    {
        public KorObuhvataGrupuMapiranja() {
            //Mapiranje tabele
            Table("KOR_OBUHVATA_GRUPU");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            References(x => x.PripadaKorStoObuhvataGrupu).Column("JEDKORIME").LazyLoad();

            References(x => x.PripadaGrupiKojuObuhvataKor).Column("JEDIMEGRUPE").LazyLoad();
        }
    }
}
