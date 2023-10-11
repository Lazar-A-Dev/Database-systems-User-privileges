using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class PredSifreKorMapiranja : ClassMap<PredSifreKor>
    {
        public PredSifreKorMapiranja() {
            Table("PREDHODNE_SIFRE_KORISNIKA");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.PredhodnaSifra, "PREDHODNASIFRA");

            References(x => x.PredSifrePripadajuSistemu).Column("SPKOD").LazyLoad();
        }
    }
}
