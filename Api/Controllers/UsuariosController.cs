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



        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Usuarios usuarios)
        {
            if (Id != usuarios.idUsuario)
                return BadRequest();

            var existingUser = _usuarioService.Get(Id);
            if (existingUser is null)
                return NotFound();

            _usuarioService.Update(usuarios);

            return NoContent();
        }



        [HttpPost]
        public ActionResult<UsuariosDTO> Create(Usuarios usuario)
        {
            var existeUser = _usuarioService.Get(usuario.idUsuario);
            if (existeUser != null)
            {
                return BadRequest($"Una obra con el ID {usuario.idUsuario} ya existe.");
            }

            _usuarioService.Add(usuario);
            return CreatedAtAction(nameof(Create), new { Id = usuario.idUsuario }, usuario);

        }



        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var usuario = _usuarioService.Get(Id);

            if (usuario is null)
                return NotFound();

            _usuarioService.Delete(Id);

            return NoContent();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid login model");
            }

            
            var usuario = _usuarioService.Authenticate(loginModel.nombreUsuario, loginModel.passwordUsuario);

            if (usuario == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok(usuario); 
        }
        
    }
}
