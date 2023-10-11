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
    public class ProfilController : ControllerBase
    {
        private readonly IProfilService _profilService;
        public ProfilController(IProfilService profil)
        {
            _profilService = profil;
        }

        [HttpGet("getprofil")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Profil))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetProfil([FromQuery(Name = "redniBr")] int redniBr)
        {
            try
            {
                var profil = _profilService.UcitajInfoProfila(redniBr);

                return Ok(profil);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("dodajprofil")]
        public IActionResult DodajProfil([FromBody] Profil noviprofil)
        {
            try
            {
                _profilService.DodajProfil(noviprofil);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("editprofil")]
        public IActionResult EditProfil([FromBody] ProfilDTO dto)
        {
            try
            {
                _profilService.EditProfil(dto);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("brisiprofil")]
        public IActionResult BrisiProfil([FromBody] ProfilDTO dto)
        {
            try
            {
                _profilService.BrisiProfil(dto.Id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
