using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSPruebaUTP.Models.Request;
using WSPruebaUTP.Models.Response;
using WSPruebaUTP.Services;

namespace WSPruebaUTP.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
       
        [HttpPost("login")]
        public IActionResult autentificar([FromBody] AutenRequest model)
        {
            GenericResponse response = new GenericResponse();

            var userResponse = _usuarioService.Autenticacion(model);

            if (userResponse == null )
            {
                response.Exito = 0;
                response.Mensaje = "Usuario o Contraseña Incorrecta";

                return BadRequest(response);
            }

            response.Exito = 1;
            response.Data = userResponse;
            response.Mensaje = "Ok";
            return Ok(response);
        }
    }
}
