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
    public class EmailAdresaController : ControllerBase
    {
        private readonly IEmailAdresaService _emailadresaService;
        public EmailAdresaController(IEmailAdresaService broj)
        {
            _emailadresaService = broj;
        }

        [HttpGet("getemailadresa")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmailAdresa))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelefona([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _emailadresaService.UcitajEmailAdresa(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajemailadresa")]
        public IActionResult DodajEmailAdresa([FromBody] KorisnikDTO dto)
        {
            try
            {
                _emailadresaService.UbaciEmailAdresa(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editemailadresa")]
        public IActionResult EditEmailAdresa([FromBody] EmailAdresaDTO dto)
        {
            try
            {
                _emailadresaService.EditEmailAdresa(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiemailadresa")]
        public IActionResult BrisiEmailAdresa([FromBody] EmailAdresaDTO dto)
        {
            try
            {
                _emailadresaService.BrisiEmailAdresa(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
