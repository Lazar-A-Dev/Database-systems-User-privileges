using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika.Mapiranja
{
    class KorisnikISMapiranja : ClassMap<KorisnikIS>
    {
        public KorisnikISMapiranja()
        {
            //Mapiranje tabele
            Table("KORISNIK_IS");

            //Mapiranje primarnog kljuca
            Id(x => x.Id, "KORIME").GeneratedBy.Assigned();

            //Mapiranje svojstva
            Map(x => x.DatRodj, "DATRODJ");
            Map(x => x.JedMatBr, "JEDMATBR");
            Map(x => x.VremePoc, "VREMEPOC");
            Map(x => x.VremeZav, "VREMEZAV");
            Map(x => x.ImeRadnogMesta, "IMERADNOGMESTA");
            Map(x => x.FunKojuObavlja, "FUNKOJUOBAVLJA");
            Map(x => x.BrKancelarije, "BRKANCELARIJE");
            Map(x => x.SifraKor, "SIFRAKOR");
            Map(x => x.Ime, "IME");
            Map(x => x.ImeRod, "IMEROD");
            Map(x => x.Prezime, "PREZIME");


            HasManyToMany(x => x.Grupe)
               .Table("KOR_OBUHVATA_GRUPU")
               .ParentKeyColumn("JEDKORIME")
               .ChildKeyColumn("JEDIMEGRUPE")
               .Cascade.All();

            HasManyToMany(x => x.Profili)
                .Table("KOR_POSEDUJE_PROFIL")
                .ParentKeyColumn("JEDKORIME")
                .ChildKeyColumn("REDBRPROF")
                .Cascade.All();

            HasMany(x => x.Telefoni).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.IpAdrese).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.EAdrese).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.Provera).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.PokusajPrijave).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.KorDodeljGrupi).KeyColumn("JEDKORIME").Cascade.All();

            HasMany(x => x.KorNadDodeljKorPod).KeyColumn("JEDKORIMENAD").Cascade.All();

            HasMany(x => x.KorPodKomeDodeljKorNad).KeyColumn("JEDKORIMEPOD").Cascade.All();
        }
    }
}
