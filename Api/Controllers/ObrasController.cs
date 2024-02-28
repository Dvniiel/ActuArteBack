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


        [HttpGet("{Id}")]
        public ActionResult<Obras> Get(int Id)
        {
            var obras = _obraService.Get(Id);

            if (obras == null)
                return NotFound();

            return obras;
        }


        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Obras obras)
        {
            if (Id != obras.idObra)
                return BadRequest();

            var existingObra = _obraService.Get(Id);
            if (existingObra is null)
                return NotFound();

            _obraService.Update(obras);

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
            return CreatedAtAction(nameof(Create), new { Id = obra.idObra }, obra);

        }



        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var obras = _obraService.Get(Id);

            if (obras is null)
                return NotFound();

            _obraService.Delete(Id);

            return NoContent();
        }

        [HttpPost("{id}/Sesion/{sesionId}")]
        public IActionResult AddObra(int id, int sesionId, [FromBody] List<int> asientos)
        {
                if (asientos == null)
                {
                    return BadRequest("No hay información de asiento para agregar.");
                }

                foreach (var asiento in asientos)
                {
                    _obraService.AddObra(id, sesionId, asiento);
                }

                return Ok("Asientos añadidos correctamente.");
        }
    }
}