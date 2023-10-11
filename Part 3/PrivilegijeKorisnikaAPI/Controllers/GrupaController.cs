using Microsoft.AspNetCore.Mvc;
using PrivilegijeKorisnika.Entiteti;
using PrivilegijeKorisnikaAPI.DTOs;
using PrivilegijeKorisnikaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrupaController : ControllerBase
    {
        private readonly IGrupaService _grupaService;
        public GrupaController(IGrupaService grupa)
        {
            _grupaService = grupa;
        }

        [HttpGet("getgrupa")]
        public IActionResult GetGrupa([FromQuery(Name = "jedIme")] string jedIme)
        {
            try
            {
                var grupa = _grupaService.UcitajInfoGrupe(jedIme);

                return Ok(grupa);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajgrupu")]
        public IActionResult DodajGrupu([FromBody] GrupaKorisnika novagrupa)
        {
            try
            {
                _grupaService.DodajGrupu(novagrupa);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editgrupe")]
        public IActionResult EditGrupe([FromBody] GrupaDTO dto)
        {
            try
            {
                _grupaService.EditGrupu(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisigrupu")]
        public IActionResult BrisiGrupu([FromBody] GrupaDTO dto)
        {
            try
            {
                _grupaService.BrisiGrupu(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
