using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnikaAPI.Entiteti;

namespace PrivilegijeKorisnikaAPI.Mapiranja
{
    class EmailAdresaMapiranja : ClassMap<EmailAdresa>
    {
        public EmailAdresaMapiranja() {

            //Mapiranje tabele
            Table("EMAIL_ADRESA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            //Map(x => x.JedKorIme, "JEDKORIME");
            Map(x => x.Email, "EMAIL");


            References(x => x.EmailPripadaKor).Column("JEDKORIME").LazyLoad();
        }
    }
}
