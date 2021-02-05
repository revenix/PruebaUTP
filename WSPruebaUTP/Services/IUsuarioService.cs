using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSPruebaUTP.Models.Request;
using WSPruebaUTP.Models.Response;

namespace WSPruebaUTP.Services
{
   public  interface IUsuarioService
    {
        UsuarioResponse Autenticacion(AutenRequest model);
    }
}
