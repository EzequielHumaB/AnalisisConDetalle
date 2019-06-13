using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisDetalle.Entidades
{
   public class Analisis
    {
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public string resultado { get; set; }
        
        public Analisis()
        {
            AnalisisId = 0;
            TipoId = 0;
            resultado = string.Empty;
        }

    }
}
