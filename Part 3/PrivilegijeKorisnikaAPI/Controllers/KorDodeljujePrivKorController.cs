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
    public class KorDodeljujePrivKorController : ControllerBase
    {
        private readonly IKorDodeljujePrivKorService _kordodeljujeprivkorService;
        public KorDodeljujePrivKorController(IKorDodeljujePrivKorService broj)
        {
            _kordodeljujeprivkorService = broj;
        }

        [HttpGet("getkordodeljujeprivkor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(KorDodeljujePrivKor))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelefona([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _kordodeljujeprivkorService.UcitajKorDodeljujePrivKor(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        
        [HttpPost("dodajkordodeljujeprivkor")]
        public IActionResult DodajKorDodeljujePrivKor([FromBody] KorDodeljujePrivKorDTO2 dto)
        {
            try
            {
                _kordodeljujeprivkorService.UbaciKorDodeljujePrivKor(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
        
        [HttpPut("editkordodeljujeprivkor")]
        public IActionResult EditKorDodeljujePrivKor([FromBody] KorDodeljujePrivKorDTO dto)
        {
            try
            {
                _kordodeljujeprivkorService.EditKorDodeljujePrivKor(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisikordodeljujeprivkor")]
        public IActionResult BrisiKorDodeljujePrivKor([FromBody] KorDodeljujePrivKorDTO dto)
        {
            try
            {
                _kordodeljujeprivkorService.BrisiKorDodeljujePrivKor(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
