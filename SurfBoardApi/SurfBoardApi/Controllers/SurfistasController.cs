using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SurfBoardApi.Data;
using SurfBoardApi.Models;
using SurfBoardApi.Services;

namespace SurfBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfistasController : ControllerBase
    {
        private readonly SurfBoardContext _context;

        public SurfistasController(SurfBoardContext context)
        {
            _context = context;
        }

        [HttpPost("calcular")]
        public IActionResult CalcularVolume([FromBody] Surfista surfista)
        {
            try
            {
                surfista.VolumePrancha = VolumePranchaService.CalcularVolume(surfista.Peso, surfista.NivelExperiencia);
                _context.Surfistas.Add(surfista);
                _context.SaveChanges();
                return Ok(surfista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetSurfistas()
        {
            return Ok(_context.Surfistas.ToList());
        }
    }
}
