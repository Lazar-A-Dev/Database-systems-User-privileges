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
    public class SistemProvereController : ControllerBase
    {
        private readonly ISistemProvereService _sistemprovereService;
        public SistemProvereController(ISistemProvereService sistem)
        {
            _sistemprovereService = sistem;
        }

        [HttpGet("getsistemprovere")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SistemProvere))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSistemProvere([FromQuery(Name = "id")] int idSP)
        {
            try
            {
                var sistemprovere = _sistemprovereService.UcitajInfoSistemaProvere(idSP);

                return Ok(sistemprovere);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajsistemprovere")]
        public IActionResult DodajSistemProvere([FromBody] KorisnikDTO dto)
        {
            try
            {
                _sistemprovereService.DodajSistemProvere(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editsistemprovere")]
        public IActionResult EditSistemProvere([FromBody] SistemProvereDTO dto)
        {
            try
            {
                _sistemprovereService.EditSistemProvere(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisisistemprovere")]
        public IActionResult BrisiSistemProvere([FromBody] SistemProvereDTO dto)
        {
            try
            {
                _sistemprovereService.BrisiSistemProvere(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
