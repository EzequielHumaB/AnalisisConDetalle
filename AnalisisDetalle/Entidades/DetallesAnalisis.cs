using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnalisisDetalle.Entidades
{
    public class DetallesAnalisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public string resultado { get; set; }
        public string Descripcion {get; set; }

     
       

        public DetallesAnalisis(int id,int idtipo, string descripcion, string Res)
        {
            AnalisisId = id;
            TipoId = idtipo;
            Descripcion = descripcion;
            resultado = Res;
        }

    }
}
