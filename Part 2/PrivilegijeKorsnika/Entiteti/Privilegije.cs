using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class Privilegije
    {
        public virtual int Id { get; set; }//Broj
        public virtual string Tip { get; set; }
        public virtual IList<KorDodeljujePrivGrupi> PrivKorDodeljujeGrupi { get; set; }
        public virtual IList<KorDodeljujePrivKor> PrivKorDodeljujeKor { get; set; }
        public virtual IList<PrivZaElementeInterfejsa> ElementInt { get; set; }
        public virtual IList<PrivZaFunModApk> FunModApk { get; set; }
        public virtual IList<AdministrativnePriv> AdminPriv { get; set; }
        public Privilegije() {

            PrivKorDodeljujeGrupi = new List<KorDodeljujePrivGrupi>();
            PrivKorDodeljujeKor = new List<KorDodeljujePrivKor>();
            ElementInt = new List<PrivZaElementeInterfejsa>();
            FunModApk = new List<PrivZaFunModApk>();
            AdminPriv = new List<AdministrativnePriv>();
        }
    }
}
