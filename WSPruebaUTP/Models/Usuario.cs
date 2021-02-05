using System;
using System.Collections.Generic;

#nullable disable

namespace WSPruebaUTP.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Nota = new HashSet<Nota>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }
    }
}
