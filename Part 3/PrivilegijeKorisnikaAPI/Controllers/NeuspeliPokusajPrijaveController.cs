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
    public class NeuspeliPokusajPrijaveController : ControllerBase
    {
        private readonly INeuspeliPokusajPrijaveService _neuspelipokusajprijaveService;
        public NeuspeliPokusajPrijaveController(INeuspeliPokusajPrijaveService neuspelipokusaj)
        {
            _neuspelipokusajprijaveService = neuspelipokusaj;
        }

        [HttpGet("getneuspelipokusajprijave")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NeuspeliPokusajPrijave))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKorisnk([FromQuery(Name = "Id")] int IdNPP)
        {
            try
            {
                var neuspelipokusaj = _neuspelipokusajprijaveService.UcitajInfoNeuspesnogPokusajaPrijave(IdNPP);

                return Ok(neuspelipokusaj);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajneuspelipokusajprijave")]
        public IActionResult DodajNeuspeliPokusajPrijave([FromBody] KorisnikDTO dto)
        {
            try
            {
                _neuspelipokusajprijaveService.DodajNeuspeliPokusajPrijave(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editneuspelipokusajprijave")]
        public IActionResult EditNeuspeliPokusajPrijave([FromBody] NeuspeliPokusajPrijaveDTO dto)
        {
            try
            {
                _neuspelipokusajprijaveService.EditNeuspeliPokusajPrijave(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisineuspelipokusajprijave")]
        public IActionResult BrisiSistemProvere([FromBody] NeuspeliPokusajPrijaveDTO dto)
        {
            try
            {
                _neuspelipokusajprijaveService.BrisiNeuspeliPokusajPrijave(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
