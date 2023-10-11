using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class NeuspeliPokusajPrijave
    {
        public virtual int Id { get; set; }//Kod
        public virtual string PogresnaSifra { get; set; }
        public virtual string Datum { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string IpAdresa { get; set; }
        public virtual string SifraKor { get; set; }
        public virtual KorisnikIS NeuspeliPokPamtiKor { get; set; }
        public NeuspeliPokusajPrijave() { 
            
        }
    }
}
