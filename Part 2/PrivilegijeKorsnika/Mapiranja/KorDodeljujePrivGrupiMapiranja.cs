using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorDodeljujePrivGrupiMapiranja : ClassMap<KorDodeljujePrivGrupi>
    {
        public KorDodeljujePrivGrupiMapiranja() {
            //Mapiranje tabele
            Table("KOR_DODELJUJE_PRIV_GRUPI");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.DatumDodele, "DATUMDODELE");

            References(x => x.PripadaKorStoDodeljGrupi).Column("JEDKORIME").LazyLoad();

            References(x => x.PripadaGrupiKojojDodeljKor).Column("JEDIMEGRUPE").LazyLoad();

            References(x => x.PripadaPrivKojiKorDodeljGrupi).Column("JEDBRPRIV").LazyLoad();
        }
    }
}
