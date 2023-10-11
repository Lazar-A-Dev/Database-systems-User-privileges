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
    public class SpisakIpAdresaController : ControllerBase
    {
        private readonly ISpisakIpAdresaService _spisakipadresaService;
        public SpisakIpAdresaController(ISpisakIpAdresaService kod)
        {
            _spisakipadresaService = kod;
        }

        [HttpGet("getspisakipadresa")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SpisakIpAdresa))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetBrTelefona([FromQuery(Name = "Id")] int kod)
        {
            try
            {
                var ip = _spisakipadresaService.UcitajSpisakIpAdresa(kod);

                return Ok(ip);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajspisakipadresa")]
        public IActionResult DodajKorisnika([FromBody] KorisnikDTO dto)
        {
            try
            {
                _spisakipadresaService.UbaciSpisakIpAdresa(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editspisakipadresa")]
        public IActionResult EditSpisakIpAdresa([FromBody] SpisakIpAdresaDTO dto)
        {
            try
            {
                _spisakipadresaService.EditSpisakIpAdresa(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisispisakipadresa")]
        public IActionResult BrisiSpisakIpAdresa([FromBody] SpisakIpAdresaDTO dto)
        {
            try
            {
                _spisakipadresaService.BrisiSpisakIpAdresa(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
