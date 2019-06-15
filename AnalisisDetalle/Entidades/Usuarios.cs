using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnalisisDetalle.Entidades
{
   public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string cedula { get; set; }
        public DateTime fechaIngreso { get; set; }
       
        public Usuarios()
        {
            UsuarioId = 0;
            nombre = string.Empty;
            email = string.Empty;
            cedula = string.Empty;
            fechaIngreso = DateTime.Now;
        }

    }
}
