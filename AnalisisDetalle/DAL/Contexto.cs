using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AnalisisDetalle.Entidades;

namespace AnalisisDetalle.DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Analisis> analisis { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<TiposAnalisis> tiposAnalises { get; set; }
        public Contexto() :base("ConStr")
        { }

    }
}
