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
    public class PrivZaElIntController : ControllerBase
    {
        private readonly IPrivZaElIntService _privzaelintService;
        public PrivZaElIntController(IPrivZaElIntService broj)
        {
            _privzaelintService = broj;
        }

        [HttpGet("getprivzaelint")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PrivZaElementeInterfejsa))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelefona([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _privzaelintService.UcitajPrivZaElInt(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajprivzaelint")]
        public IActionResult DodajPrivZaElInt([FromBody] PrivilegijeDTO dto)
        {
            try
            {
                _privzaelintService.UbaciPrivZaElInt(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editprivzaelint")]
        public IActionResult EditPrivZaElInt([FromBody] PrivZaElIntDTO dto)
        {
            try
            {
                _privzaelintService.EditPrivZaElInt(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiprivzaelint")]
        public IActionResult BrisiPrivZaElInt ([FromBody] PrivZaElIntDTO dto)
        {
            try
            {
                _privzaelintService.BrisiPrivZaElInt(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
