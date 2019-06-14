using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using AnalisisDetalle.Entidades;
using AnalisisDetalle.DAL;

namespace AnalisisDetalle.BLL
{
    public class TiposAnalisisBLL
    {
        public static bool Guardar(TiposAnalisis tipoanalisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.tiposAnalises.Add(tipoanalisis) != null)
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

        public static bool Modificar(TiposAnalisis tipoanalisis)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tipoanalisis).State = EntityState.Modified;
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
                var eliminar = contexto.tiposAnalises.Find(id);
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

        public static TiposAnalisis Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TiposAnalisis tipoanalisis = new TiposAnalisis();
            try
            {
                tipoanalisis = contexto.tiposAnalises.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tipoanalisis;
        }

        public static List<TiposAnalisis> GetList(Expression<Func<TiposAnalisis, bool>> tipoanalisis)
        {
            List<TiposAnalisis> lista = new List<TiposAnalisis>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.tiposAnalises.Where(tipoanalisis).ToList();
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
