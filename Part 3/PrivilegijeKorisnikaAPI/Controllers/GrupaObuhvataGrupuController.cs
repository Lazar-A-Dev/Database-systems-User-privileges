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
    public class GrupaObuhvataGrupuController : ControllerBase
    {
        private readonly IGrupaObuhvataGrupuService _grupaobuhvatagrupuService;
        public GrupaObuhvataGrupuController(IGrupaObuhvataGrupuService kod)
        {
            _grupaobuhvatagrupuService = kod;
        }

        [HttpGet("getgrupaobuhvatagrupu")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GrupaObuhvataGrupu))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGrupaObuhvataGrupu([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _grupaobuhvatagrupuService.UcitajGrupaObuhvataGrupu(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("dodajgrupaobuhvatagrupu")]
        public IActionResult DodajGrupaObuhvataGrupu([FromBody] GrupaObuhvataGrupuDTO2 dto)
        {
            try
            {
                _grupaobuhvatagrupuService.UbaciGrupaObuhvataGrupu(dto);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisigrupaobuhvatagrupu")]
        public IActionResult BrisiBrTelefona([FromBody] GrupaObuhvataGrupuDTO dto)
        {
            try
            {
                _grupaobuhvatagrupuService.BrisiGrupaObuhvataGrupu(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
