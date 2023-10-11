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
    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _korisnikService;
        public KorisnikController(IKorisnikService korisnik) {
            _korisnikService = korisnik;
        }

        [HttpGet("getkorisnik")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KorisnikIS))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKorisnk([FromQuery(Name = "idKor")] string idKor)
        {
            try {
                var korisnik = _korisnikService.UcitajInfoKor(idKor);

                return Ok(korisnik);
            }
            catch (Exception ex) {
                return BadRequest();
            }

        }

        [HttpPost("dodajkorisnika")]
        public IActionResult DodajKorisnika([FromBody] KorisnikIS noviKorisnik)
        {
            try
            {
                _korisnikService.UbaciKor(noviKorisnik);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editkorisnika")]
        public IActionResult EditKorisnika([FromBody] KorisnikDTO dto)
        {
            try
            {
                _korisnikService.EditKorisnika(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisikorisnika")]
        public IActionResult BrisiKorisnika([FromBody] KorisnikDTO dto)
        {
            try
            {
                _korisnikService.BrisiKorisnika(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
