using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorDodeljujePrivKorMapiranja : ClassMap<KorDodeljujePrivKor>
    {
        public KorDodeljujePrivKorMapiranja() {
            //Mapiranje tabele
            Table("KOR_DODELJUJE_PRIV_KOR");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.DatumDodele, "DATUMDODELE");

            References(x => x.PripadaKorNadStoDodeljKorPod).Column("JEDKORIMENAD").LazyLoad();

            References(x => x.PripadaKorPodKomeDodeljKorNad).Column("JEDKORIMEPOD").LazyLoad();

            References(x => x.PripadaPrivKojiKorNadDodeljKorPod).Column("BRPRIVKOR").LazyLoad();

        }
    }
}
