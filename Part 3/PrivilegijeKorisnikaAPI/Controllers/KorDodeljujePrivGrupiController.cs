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
    public class KorDodeljujePrivGrupiController : ControllerBase
    {
        private readonly IKorDodeljujePrivGrupiService _kordodeljujeprivgrupiService;
        public KorDodeljujePrivGrupiController(IKorDodeljujePrivGrupiService broj)
        {
            _kordodeljujeprivgrupiService = broj;
        }

        [HttpGet("getkordodeljujeprivgrupi")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KorDodeljujePrivGrupi))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKorDodeljujePrivGrupi([FromQuery(Name = "Id")] int broj)
        {
            try
            {
                var kod = _kordodeljujeprivgrupiService.UcitajKorDodeljujePrivGrupi(broj);

                return Ok(kod);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPost("dodajkordodeljujeprivgrupi")]
        public IActionResult DodajKorDodeljujePrivGrupi([FromBody] KorDodeljujePrivGrupiDTO2 dto)
        {
            try
            {
                _kordodeljujeprivgrupiService.UbaciKorDodeljujePrivGrupi(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPut("editkordodeljujeprivgrupi")]
        public IActionResult EditBrTelefona([FromBody] KorDodeljujePrivGrupiDTO dto)
        {
            try
            {
                _kordodeljujeprivgrupiService.EditKorDodeljujePrivGrupi(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisikordodeljujeprivgrupi")]
        public IActionResult BrisiBrTelefona([FromBody] KorDodeljujePrivGrupiDTO dto)
        {
            try
            {
                _kordodeljujeprivgrupiService.BrisiKorDodeljujePrivGrupi(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
