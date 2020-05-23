using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimerRegistro.DAL;
using PrimerRegistro.Models;

namespace PrimerRegistro.BLL
{
    public class ErroresBLL
    {
       public static bool Guardar(Errores errores)
        {
            if (!Existe(errores.ErrorId))
                return Insertar(errores);

            else
                return Modificar(errores);
        }

        private static bool Insertar(Errores errores)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.errores.Add(errores);
                paso = contexto.SaveChanges() > 0;
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
        
        public static bool Modificar(Errores errores)
        {
            bool pasoo = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(errores).State = EntityState.Modified;
                pasoo = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return pasoo;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var error = contexto.errores.Find(id);

                if (error != null)
                {
                    contexto.errores.Remove(error);
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

        public static Errores Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Errores errores;

            try
            {
                errores = contexto.errores.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return errores;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.errores.Any(e => e.ErrorId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
    }
}
