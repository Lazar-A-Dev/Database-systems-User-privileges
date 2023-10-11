using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivilegijeKorisnika.Entiteti
{
    public class PredSifreKor
    {
        public virtual int Id {get;set;}//Kod
        public virtual string PredhodnaSifra { get; set; }
        public virtual SistemProvere PredSifrePripadajuSistemu { get; set; }
        public PredSifreKor() { 
            
        }
    }
}
