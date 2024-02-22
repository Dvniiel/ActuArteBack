using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ObrasController : ControllerBase
    {
        private readonly ObrasService _obraService;

        public ObrasController(ObrasService obraService)
        {
            _obraService = obraService;
        }

        // GET: /Obras
        [HttpGet]
        public ActionResult<List<Obras>> GetAll() => _obraService.GetAll();
/*

        [HttpGet("{id}")]
        public ActionResult<Obras> Get(int id)
        {
            var obra = _obraService.Get(id);

            if (obra == null)
                return NotFound();

            return obra;
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, Obras obra)
        {
            if (id != obra.idObra)
                return BadRequest();

            var existingObra = _obraService.Get(id);
            if (existingObra is null)
                return NotFound();



            return NoContent();
        }


        
        [HttpPost]
        public ActionResult<Obras> Create(Obras obra)
        {
            var existeObra = _obraService.Get(obra.idObra);
            if (existeObra != null)
            {
                return BadRequest($"Una obra con el ID {obra.idObra} ya existe.");
            }

            _obraService.Add(obra);
            return CreatedAtAction(nameof(Create), new { id = obra.idObra }, obra);
        }
*/
    }
}
