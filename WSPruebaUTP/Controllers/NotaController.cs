using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSPruebaUTP.Models;
using WSPruebaUTP.Models.Request;
using WSPruebaUTP.Models.Response;
using WSPruebaUTP.Services;

namespace WSPruebaUTP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaService _nota;

        public NotaController(INotaService nota)
        {
            this._nota = nota;
        }


        [HttpPost("Crear")]
        public IActionResult CrearNota(NotaRequest model)
        {
            GenericResponse response = new GenericResponse();
            response.Exito = 0;

            try
            {
                _nota.CrearNotas(model);
                response.Exito = 1;
                response.Mensaje = "Ok";
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
                return BadRequest();
            }
            return Ok(response);

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {   
            GenericResponse response = new GenericResponse();
            response.Exito = 0;
            response.Mensaje = "No Registra Notas";
            try
            {

                int idUsuario = (int)id;
                using (BDNotasContext db = new BDNotasContext())
                {

                    var lst = db.Nota.Where(p => p.IdUsuario == id).ToList();

                    if (lst != null && lst.Count > 0)
                    {
                        response.Exito = 1;
                        response.Mensaje = "Ok";
                        response.Data = lst;
                    }

                }



            }
            catch (Exception ex)
            {
                response.Mensaje ="Ocurrio una excepcion: " + ex.Message;
            }
            return Ok(response);

        }
    }
}
