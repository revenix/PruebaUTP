using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WSPruebaUTP.Models.Request
{
    public class NotaRequest
    {

        public NotaRequest()
        {
          
        }
        [ExisteUsuario(ErrorMessage = "Usuario no existe")]
        public int idUsuario { get; set; }
         
        [Range(0, 20, ErrorMessage = "Nota1 debe estar en el rango de 0 a 20")]
        public decimal Nota1 { get; set; }
        [Range(0, 20, ErrorMessage = "Nota2 debe estar en el rango de 0 a 20")]
        public decimal Nota2 { get; set; }
        [Range(0, 20, ErrorMessage = "Nota3 debe estar en el rango de 0 a 20")]
        public decimal Nota3 { get; set; }
        [Range(0, 20, ErrorMessage = "Nota4 debe estar en el rango de 0 a 20")]
        public decimal Nota4 { get; set; }

    }

    #region Validaciones

    public class ExisteUsuario : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int idUsuario = (int)value;
            using (var db = new BDNotasContext())
            {
                if (db.Usuarios.Find(idUsuario) == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
    #endregion
}
