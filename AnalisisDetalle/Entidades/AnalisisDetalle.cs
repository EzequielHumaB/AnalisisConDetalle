using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnalisisDetalle.Entidades
{
    public class AnalisisDetalle
    {
        [Key]
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        string resultado { get; set; }

        public AnalisisDetalle()
        {
            AnalisisId = 0;
            TipoId = 0;
            resultado = string.Empty;
        }
        
        public AnalisisDetalle(int idanalisis, int idtipo, string res)
        {
            AnalisisId = idanalisis;
            TipoId = idtipo;
            resultado = res;
        }

    }
}
