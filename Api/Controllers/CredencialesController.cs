using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CredencialesController : ControllerBase
    {
        private readonly CredentialsService _credentialsService;

        private readonly ILogger<CredencialesController> _logger;

        public CredencialesController(CredentialsService credentialsService, ILogger<CredencialesController> logger)
        {
            _credentialsService = credentialsService;
            _logger = logger;
        }


        //ENDPOINT PARA LOGIN
        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuariosDTO usuariosDTO)
        {
            try
            {
                _logger.LogInformation("Intentando logear usuario");


                var usuario = _credentialsService.Authenticate(usuariosDTO);

                if (usuario == null)
                {
                    return Unauthorized("Credenciales incorrectas");
                }

                _logger.LogInformation("Usuario correcto");
                return Ok(usuario);
            }
            catch
            {
                _logger.LogError("Error de autenticación");
                return StatusCode(500, "Error interno del servidor");
            }
        }


        //ENDPOINT PARA REGISTRO
        [HttpPost("register")]
        public ActionResult<UsuariosDTO> Create(Usuarios usuario)
        {
            try
            {
                var existeUser = _credentialsService.Get(usuario.idUsuario);
                if (existeUser != null)
                {
                    return BadRequest($"Una obra con el ID {usuario.idUsuario} ya existe.");
                }

                _credentialsService.Add(usuario);

                _logger.LogInformation("Usuario posteado correctamente");
                return CreatedAtAction(nameof(Create), new { Id = usuario.idUsuario }, usuario);
            }
            catch
            {
                _logger.LogError("Error al postear un Usuario");
                return StatusCode(500, "Error interno del servidor");
            }
        }


         [HttpGet("{Id}")]
        public ActionResult<Usuarios> Get(int Id)
        {
            try
            {
                var usuarios = _credentialsService.Get(Id);

                if (usuarios == null)
                    return NotFound();

                _logger.LogInformation("Recogiendo usuario por ID");
                return usuarios;
            }
            catch
            {
                _logger.LogError("Error al obtener el usuario");
                return StatusCode(400, "Usuario no encontrado");
            }
        }



    }
}