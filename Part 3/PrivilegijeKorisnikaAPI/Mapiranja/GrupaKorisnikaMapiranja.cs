using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegijeKorisnika.Entiteti;
using FluentNHibernate.Mapping;

namespace PrivilegijeKorisnika.Mapiranja
{
    class GrupaKorisnikaMapiranja : ClassMap<GrupaKorisnika>
    {
        public GrupaKorisnikaMapiranja()
        {
            //Mapiranje tabele
            Table("GRUPA_KORISNIKA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "JEDIME").GeneratedBy.Assigned();

            //mapiranje svojstava
            Map(x => x.KratakOpis, "KRATAKOPIS");
            Map(x => x.DatumKreiranja, "DATUMKREIRANJA");
            Map(x => x.VremePocPer, "VREMEPOCPER");
            Map(x => x.VremeZavPer, "VREMEZAVPER");

            HasMany(x => x.Korisnici).KeyColumn("JEDIMEGRUPE").Cascade.All();

            HasMany(x => x.IpAdreseGrupe).KeyColumn("JEDIMEGRUPE").Cascade.All();

            HasMany(x => x.NadGrupa).KeyColumn("JEDIMENADGRUPE").Cascade.All();

            HasMany(x => x.PodGrupa).KeyColumn("JEDIMEPODGRUPE").Cascade.All();

        }

    }
}
