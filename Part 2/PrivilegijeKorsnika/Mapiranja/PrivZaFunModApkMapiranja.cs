using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class PrivZaFunModApkMapiranja : ClassMap<PrivZaFunModApk>
    {
        public PrivZaFunModApkMapiranja() {
            //Mapiranje tabele
            Table("PRIV_ZA_FUN_MOD_APK");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.Opis, "OPIS");

            References(x => x.FunModApkPripadaPriv).Column("TIPPRIVILEGIJE").LazyLoad();
        }
    }
}
