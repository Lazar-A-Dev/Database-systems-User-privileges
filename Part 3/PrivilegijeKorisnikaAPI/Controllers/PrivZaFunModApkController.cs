using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Entiteti;
using PrivilegijeKorisnikaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrivZaFunModApkController : ControllerBase
    {
        private readonly IPrivZaFunModApkService _privzafunmodapkService;
        public PrivZaFunModApkController(IPrivZaFunModApkService priv)
        {
            _privzafunmodapkService = priv;
        }

        [HttpGet("getprivzafunmodapk")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PrivZaFunModApk))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPrivZaFunModApk([FromQuery(Name = "Id")] int IdPriv)
        {
            try
            {
                var priv = _privzafunmodapkService.UcitajInfoPrivZaFunModApk(IdPriv); 

                return Ok(priv);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajprivzafunmodapk")]
        public IActionResult DodajPrivZaFunModApk([FromBody] PrivilegijeDTO dto)
        {
            try
            {
                _privzafunmodapkService.UbaciPrivZaFunModApk(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editprivzafunmodapk")]
        public IActionResult EditPrivZaFunModApk([FromBody] PrivZaFunModApkDTO dto)
        {
            try
            {
                _privzafunmodapkService.EditPrivZaFunModApk(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiprivzafunmodapk")]
        public IActionResult BrisiPrivZaFunModApk([FromBody] PrivZaFunModApkDTO dto)
        {
            try
            {
                _privzafunmodapkService.BrisiPrivZaFunModApk(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
