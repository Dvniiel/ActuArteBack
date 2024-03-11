using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AsientosController : ControllerBase
    {
        private readonly AsientosService _asientoService;

        public AsientosController(AsientosService asientoService)
        {
            _asientoService = asientoService;
        }

        // GET: /Asientos
        [HttpGet]
        public ActionResult<List<Asientos>> GetAll() => _asientoService.GetAll();

        [HttpGet("{Id}")]
        public ActionResult<Asientos> Get(int Id)
        {
            var asientos = _asientoService.Get(Id);

            if (asientos == null)
                return NotFound();

            return asientos;
        }


        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Asientos asientos)
        {
            if (Id != asientos.idAsiento)
                return BadRequest();

            var existingAsiento = _asientoService.Get(Id);
            if (existingAsiento is null)
                return NotFound();

            _asientoService.Update(asientos);

            return NoContent();
        }


    }
}
