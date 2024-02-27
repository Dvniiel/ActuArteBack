using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuariosController : ControllerBase
    {
        private readonly UsuariosService _usuarioService;

        public UsuariosController(UsuariosService usuarioService)
        {
            _usuarioService = usuarioService;
        }



        [HttpGet]
        public ActionResult<List<Usuarios>> GetAll() => _usuarioService.GetAll();



        [HttpGet("{Id}")]
        public ActionResult<Usuarios> Get(int Id)
        {
            var usuarios = _usuarioService.Get(Id);

            if (usuarios == null)
                return NotFound();

            return usuarios;
        }
    }
}