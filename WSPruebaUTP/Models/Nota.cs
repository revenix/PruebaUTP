using System;
using System.Collections.Generic;

#nullable disable

namespace WSPruebaUTP.Models
{
    public partial class Nota
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }
        public decimal Nota4 { get; set; }
        public decimal Promedio { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
