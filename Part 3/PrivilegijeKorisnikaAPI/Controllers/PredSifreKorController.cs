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
    public class PredSifreKorController : ControllerBase
    {
        private readonly IPredSifreKorService _predsifrekorService;
        public PredSifreKorController(IPredSifreKorService broj)
        {
            _predsifrekorService = broj;
        }

        [HttpGet("getpredsifrekor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PredSifreKor))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPredSifreKor([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _predsifrekorService.UcitajPredSifreKor(kod);
                
                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajpredsifrekor")]
        public IActionResult DodajKorisnika([FromBody] SistemProvereDTO dto)
        {
            try
            {
                _predsifrekorService.UbaciPredSifreKorService(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editpredsifrekor")]
        public IActionResult EditPredSifreKor([FromBody] PredSifreKorDTO dto)
        {
            try
            {
                _predsifrekorService.EditPredSifreKor(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisipredsifrekor")]
        public IActionResult BrisiBPredSifreKor([FromBody] PredSifreKorDTO dto)
        {
            try
            {
                _predsifrekorService.BrisiPredSifreKor(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
