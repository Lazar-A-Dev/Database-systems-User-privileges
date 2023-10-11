using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Services
{
    public interface IPrivZaFunModApkService
    {
        PrivZaFunModApk UcitajInfoPrivZaFunModApk(int p);
        void UbaciPrivZaFunModApk(PrivilegijeDTO dto);
        void EditPrivZaFunModApk(PrivZaFunModApkDTO dto);
        void BrisiPrivZaFunModApk(int IdPriv);
    }
}
