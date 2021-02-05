using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSPruebaUTP.Models;
using WSPruebaUTP.Models.Request;
using WSPruebaUTP.Models.Response;

namespace WSPruebaUTP.Services
{
    public class NotaService : INotaService
    {
        public void CrearNotas(NotaRequest model)
        {
  
            try
            {
                using (BDNotasContext db = new BDNotasContext())
                {
                    Nota objNota = new Nota();

                    objNota.IdUsuario = model.idUsuario;
                    objNota.Nota1 = model.Nota1;
                    objNota.Nota2 = model.Nota2;
                    objNota.Nota3 = model.Nota3;
                    objNota.Nota4 = model.Nota4;

                    objNota.Promedio = ((model.Nota1+ model.Nota2 + model.Nota3 + model.Nota4) /4);

                    db.Nota.Add(objNota);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio una excepcion: " + ex.ToString());
            }

        }

    }
}
