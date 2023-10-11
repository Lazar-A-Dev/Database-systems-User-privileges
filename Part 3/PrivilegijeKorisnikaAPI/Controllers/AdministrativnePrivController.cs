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
    public class AdministrativnePrivController : ControllerBase
    {
        private readonly IAdministrativnePrivService _administrativneprivService;
        public AdministrativnePrivController(IAdministrativnePrivService broj)
        {
            _administrativneprivService = broj;
        }

        [HttpGet("getadministrativnepriv")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AdministrativnePriv))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAdministrativnePriv([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _administrativneprivService.UcitajAdministrativnePriv(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("dodajadministrativnepriv")]
        public IActionResult DodajAdministrativnePriv([FromBody] PrivilegijeDTO dto)
        {
            try
            {
                _administrativneprivService.UbaciAdministrativnePriv(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editadministrativnepriv")]
        public IActionResult EditAdministrativnePriv([FromBody] AdministrativnePrivDTO dto)
        {
            try
            {
                _administrativneprivService.EditAdministrativnePriv(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiadministrativnepriv")]
        public IActionResult BrisiAdministrativnePriv([FromBody] AdministrativnePrivDTO dto)
        {
            try
            {
                _administrativneprivService.BrisiAdministrativnePriv(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
