using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class KorisnikIS
    {
        public virtual string Id { get; set; }//KorIme
        public virtual long JedMatBr { get; set; }
        public virtual DateTime DatRodj { get; set; }
        public virtual string VremePoc { get; set; }
        public virtual string VremeZav { get; set; }
        public virtual string ImeRadnogMesta { get; set; }
        public virtual string FunKojuObavlja { get; set; }
        public virtual int BrKancelarije { get; set; }
        public virtual string SifraKor { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRod { get; set; }
        public virtual string Prezime { get; set; }

        public virtual IList<GrupaKorisnika> Grupe { get; set; }
        public virtual IList<Profil> Profili { get; set; }
        public virtual IList<BrTelefona> Telefoni { get; set; }
        public virtual IList<SpisakIpAdresa> IpAdrese { get; set; }
        public virtual IList<EmailAdresa> EAdrese { get; set; }
        public virtual IList<SistemProvere> Provera { get; set; }
        public virtual IList<NeuspeliPokusajPrijave> PokusajPrijave { get; set; }
        public virtual IList<KorDodeljujePrivGrupi> KorDodeljGrupi { get; set; }
        public virtual IList<KorDodeljujePrivKor> KorNadDodeljKorPod { get; set; }
        public virtual IList<KorDodeljujePrivKor> KorPodKomeDodeljKorNad { get; set; }
        public KorisnikIS()
        {
            Grupe = new List<GrupaKorisnika>();
            Profili = new List<Profil>();
            Telefoni = new List<BrTelefona>();
            IpAdrese = new List<SpisakIpAdresa>();
            EAdrese = new List<EmailAdresa>();
            Provera = new List<SistemProvere>();
            PokusajPrijave = new List<NeuspeliPokusajPrijave>();
            KorDodeljGrupi = new List<KorDodeljujePrivGrupi>();
            KorNadDodeljKorPod = new List<KorDodeljujePrivKor>();
            KorPodKomeDodeljKorNad = new List<KorDodeljujePrivKor>();
        }
    }
}
