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



    }
}
