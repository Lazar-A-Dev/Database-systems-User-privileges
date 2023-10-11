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
    public class BrTelefonaController : ControllerBase
    {
        private readonly IBrTelefonaService _brtelefonaService;
        public BrTelefonaController(IBrTelefonaService broj)
        {
            _brtelefonaService = broj;
        }

        [HttpGet("getbrtelefona")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BrTelefona))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelefona([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _brtelefonaService.UcitajBrTelefona(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("dodajbrtelefona")]
        public IActionResult DodajBrojTelefona([FromBody] KorisnikDTO dto)
        {
            try
            {
                _brtelefonaService.UbaciBrTelefona(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editbrtelefona")]
        public IActionResult EditBrTelefona([FromBody] BrTelefonaDTO dto)
        {
            try
            {
                _brtelefonaService.EditBrTelefona(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisibrtelefona")]
        public IActionResult BrisiBrTelefona([FromBody] BrTelefonaDTO dto)
        {
            try
            {
                _brtelefonaService.BrisiBrTelefona(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
