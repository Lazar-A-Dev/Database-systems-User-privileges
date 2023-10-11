using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class ProfilMapiranja : ClassMap<Profil>
    {
        public ProfilMapiranja(){
            //Mapiranje tabele
            Table("PROFIL");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "REDNIBR").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.BojaPozadine, "BOJAPOZADINE");
            Map(x => x.SpisakElGrafInt, "SPISAKELGRAFINT");

            HasMany(x => x.KorisniciP).KeyColumn("REDBRPROF").Cascade.All();

        }

    }
}
