using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnalisisDetalle.Entidades
{
   public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public int UsuarioId { get; set; }
        public virtual List<DetallesAnalisis> Detalles { get; set; }
        
        public Analisis()
        {
            AnalisisId = 0;
            TipoId = 0;
            UsuarioId = 0;
            Detalles = new List<DetallesAnalisis>();
        }

    }
}
