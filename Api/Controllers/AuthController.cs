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
        private readonly UsuariosService _usuarioServcie;

        private readonly ILogger<AuthController> _logger;

        public AuthController(UsuariosService usuarioService, ILogger<AuthController> logger)
        {
            _usuarioServcie = usuarioService;
            _logger = logger;
        }

    }
}