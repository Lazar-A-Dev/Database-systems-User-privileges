using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class SistemProvere
    {
        public virtual int Id { get; set; }//Kod
        public virtual DateTime SifraZadPutProm { get; set; }
        public virtual KorisnikIS SistemProvKor { get; set; }
        public virtual IList<PredSifreKor> PredSifre { get; set; }
        public SistemProvere() {

            PredSifre = new List<PredSifreKor>();
        }
    }
}
