using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class PrivilegijeMapiranja : ClassMap<Privilegije>
    {
        public PrivilegijeMapiranja() {
            //Mapiranje tabele
            Table("PRIVILEGIJE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.Tip, "TIP");

            HasMany(x => x.PrivKorDodeljujeGrupi).KeyColumn("JEDBRPRIV").Cascade.All();

            HasMany(x => x.ElementInt).KeyColumn("TIPPRIVILEGIJE").Cascade.All();

            HasMany(x => x.FunModApk).KeyColumn("TIPPRIVILEGIJE").Cascade.All();

            HasMany(x => x.AdminPriv).KeyColumn("TIPPRIVILEGIJE").Cascade.All();
        }
    }
}
