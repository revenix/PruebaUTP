using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSPruebaUTP.Models.Response
{
    public class GenericResponse
    {
        public GenericResponse()
        {
            this.Exito = 0;
        }
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }
    }
}
