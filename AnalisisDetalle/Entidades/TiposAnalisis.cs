﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnalisisDetalle.Entidades
{
    public class TiposAnalisis
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TiposAnalisis()
        {
            TipoId = 0;
            Descripcion = string.Empty;
        }
    }
}