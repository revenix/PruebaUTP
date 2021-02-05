using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSPruebaUTP.Models;
using WSPruebaUTP.Models.Request;

namespace WSPruebaUTP.Services
{
    public interface INotaService 
    {
        public void CrearNotas(NotaRequest model);

    }
}
