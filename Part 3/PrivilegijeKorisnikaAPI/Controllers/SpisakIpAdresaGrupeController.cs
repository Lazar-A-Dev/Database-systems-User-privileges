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
    public class SpisakIpAdresaGrupeController : ControllerBase
    {
        private readonly ISpisakIpAdresaGrupeService _spisakipadresagrupeService;
        public SpisakIpAdresaGrupeController(ISpisakIpAdresaGrupeService broj)
        {
            _spisakipadresagrupeService = broj;
        }

        [HttpGet("getspisakipadresagrupe")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SpisakIpAdresaGrupe))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSpisakIpAdresaGrupe([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var broj = _spisakipadresagrupeService.UcitajSpisakIpAdresaGrupe(kod);

                return Ok(broj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajspisakipadresagrupe")]
        public IActionResult DodajSpisakIpAdresaGrupe([FromBody] GrupaDTO dto)
        {
            try
            {
                _spisakipadresagrupeService.UbaciSpisakIpAdresaGrupe(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editspisakipadresagrupe")]
        public IActionResult EditBrTelefona([FromBody] SpisakIpAdresaGrupe dto)
        {
            try
            {
                //_brtelefonaService.EditBrTelefona(dto);
                _spisakipadresagrupeService.EditSpisakIpAdresaGrupe(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisispisakipadresagrupe")]
        public IActionResult BrisiSpisakIpAdresaGrupe([FromBody] SpisakIpAdresaGrupeDTO dto)
        {
            try
            {
                _spisakipadresagrupeService.BrisiSpisakIpAdresaGrupe(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
