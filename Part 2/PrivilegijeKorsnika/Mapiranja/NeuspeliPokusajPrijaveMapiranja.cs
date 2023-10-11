using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class NeuspeliPokusajPrijaveMapiranja : ClassMap<NeuspeliPokusajPrijave>
    {
        NeuspeliPokusajPrijaveMapiranja() {
            //Mapiranje tabele
            Table("NEUSPELI_POKUSAJ_PRIJAVE");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KOD").GeneratedBy.TriggerIdentity();

            //Mapiranje svojstva
            Map(x => x.PogresnaSifra, "POGRESNASIFRA");
            Map(x => x.Datum, "DATUM");
            Map(x => x.Vreme, "VREME");
            Map(x => x.IpAdresa, "IPADRESA");
            Map(x => x.SifraKor, "SIFRAKOR");

            References(x => x.NeuspeliPokPamtiKor).Column("JEDKORIME").LazyLoad();
        }
    }
}
