using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class GrupaKorisnika
    {
        public virtual string Id { get; set; }//JedIme
        public virtual string KratakOpis { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual string VremePocPer { get; set; }
        public virtual string VremeZavPer { get; set; }

        public virtual IList<KorisnikIS> Korisnici { get; set; }
        public virtual IList<SpisakIpAdresaGrupe> IpAdreseGrupe { get; set; }
        public virtual IList<GrupaObuhvataGrupu> NadGrupa { get; set; }
        public virtual IList<GrupaObuhvataGrupu> PodGrupa { get; set; }
        public virtual IList<KorDodeljujePrivGrupi> GrupiDodjKor { get; set; }

        public GrupaKorisnika() {

            Korisnici = new List<KorisnikIS>();
            IpAdreseGrupe = new List<SpisakIpAdresaGrupe>();
            NadGrupa = new List<GrupaObuhvataGrupu>();
            PodGrupa = new List<GrupaObuhvataGrupu>();
            GrupiDodjKor = new List<KorDodeljujePrivGrupi>();
        }
    }
}
