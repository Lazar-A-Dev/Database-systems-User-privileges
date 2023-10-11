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
    public class PrivilegijeController : ControllerBase
    {
        private readonly IPrivilegijeService _privilegijeService;
        public PrivilegijeController(IPrivilegijeService privilegije)
        {
            _privilegijeService = privilegije;
        }

        [HttpGet("getprivilegije")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Privilegije))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPrivilegije([FromQuery(Name = "Id")] int idPriv)
        {
            try
            {
                var privliegije = _privilegijeService.UcitajInfoPrivilegije(idPriv);

                return Ok(privliegije);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajprivilegije")]
        public IActionResult DodajPrivilegije([FromBody] Privilegije novaPriv)
        {
            try
            {
                _privilegijeService.DodajPrivilegiju(novaPriv);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editprivilegije")]
        public IActionResult EditPrivilegije([FromBody] PrivilegijeDTO dto)
        {
            try
            {
                _privilegijeService.EditPrivilegije(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiprivilegije")]
        public IActionResult BrisiPrivilegiju([FromBody] Privilegije dto)
        {
            try
            {
                _privilegijeService.BrisiPrivilegije(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
