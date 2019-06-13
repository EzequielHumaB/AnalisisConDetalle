using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisDetalle.Entidades
{
   public class Usuario
    {
        public int UsuarioId { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public DateTime fechaIngreso { get; set; }
       
        public Usuario()
        {
            UsuarioId = 0;
            nombre = string.Empty;
            email = string.Empty;
            usuario = string.Empty;
            fechaIngreso = DateTime.Now;
        }

    }
}
