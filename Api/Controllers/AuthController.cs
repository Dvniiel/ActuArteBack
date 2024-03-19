using Microsoft.AspNetCore.Mvc;
using ActuArte.Models;
using ActuArte.Business;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ActuArte.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly CredentialsService _credentialsService;

        private readonly ILogger<AuthController> _logger;

        public AuthController(CredentialsService credentialsService, ILogger<AuthController> logger)
        {
            _credentialsService = credentialsService;
            _logger = logger;
        }


        // PREGUNTAR POR QUE NO FUNCIONA
        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuariosDTO usuariosDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid login model");
                }


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

    }
}