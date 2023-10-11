using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class BrTelefonaMapiranja : ClassMap<BrTelefona>
    {
        public BrTelefonaMapiranja(){
            //Mapiranje tabele
            Table("BR_TELEFONA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.Telefon, "TELEFON");

            References(x => x.BrPripadaKor).Column("JEDKORIME").LazyLoad();
        }

    }
}
