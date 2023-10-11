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
    public class RodStavkaMenijaController : ControllerBase
    {
        private readonly IRodStavkaMenijaService _rodstavkamenijaService;
        public RodStavkaMenijaController(IRodStavkaMenijaService broj)
        {
            _rodstavkamenijaService = broj;
        }

        [HttpGet("getrodstavkamenija")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RodStavkaMenija))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRodStavkaMenija([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _rodstavkamenijaService.UcitajRodStavkaMenija(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("dodajrodstavkamenija")]
        public IActionResult DodajRodStavkaMenija([FromBody] RodStavkaMenijaDTO2 dto)
        {
            try
            {
                _rodstavkamenijaService.UbaciRodStavkaMenija(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisirodstavkamenija")]
        public IActionResult BrisiRodStavkaMenija([FromBody] RodStavkaMenijaDTO dto)
        {
            try
            {
                _rodstavkamenijaService.BrisiRodStavkaMenija(dto.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
