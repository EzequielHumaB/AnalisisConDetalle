using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisDetalle.Entidades;
using System.Data.Entity;
using AnalisisDetalle.DAL;
using System.Linq.Expressions;

namespace AnalisisDetalle.BLL
{
  public class AnalisisBLL
    {
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.analisis.Add(analisis) != null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var anterior = contexto.analisis.Find(analisis.AnalisisId);
                //  Productos productos = ProductosClase.Buscar(producto.ProductoId);
                foreach (var item in anterior.Detalles)
                {
                    if (!analisis.Detalles.Exists(d => d.AnalisisId == item.AnalisisId))

                        contexto.Entry(item).State = EntityState.Deleted;

                }
                contexto.Entry(analisis).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.analisis.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = (contexto.SaveChanges()) > 0;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Analisis Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Analisis analisi = new Analisis();
            try
            {
                analisi = contexto.analisis.Find(id);
                analisi.Detalles.Count();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return analisi;
        }

        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> analisis)
        {
            List<Analisis> lista = new List<Analisis>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.analisis.Where(analisis).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
