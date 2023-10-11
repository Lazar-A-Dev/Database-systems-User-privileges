using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorPosedujeProfilMapiranja : ClassMap<KorPosedujeProfil>
    {
        public KorPosedujeProfilMapiranja() {
            //Mapiranje tabele
            Table("KOR_POSEDUJE_PROFIL");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            References(x => x.PripadaKorStoPosedujeProfil).Column("JEDKORIME").LazyLoad();

            References(x => x.PripadaProfiluKojPosedujeKor).Column("REDBRPROF").LazyLoad();
        }
    }
}
