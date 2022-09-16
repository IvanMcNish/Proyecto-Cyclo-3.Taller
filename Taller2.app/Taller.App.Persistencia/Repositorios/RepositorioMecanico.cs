using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;


namespace Taller.App.Persistencia
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;

        public RepositorioMecanico (ContextDb dbContext)
        {
            this.dbContext=dbContext;

        }

        public Mecanico AgregarMecanico (Mecanico m){

            var mecanicoNuevo = this.dbContext.Mecanicos.Add(m);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;

        }

        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.dbContext.Mecanicos;
        }

        public Mecanico BuscarMecanico(string idMecanico)
        {
            
            return this.dbContext.Mecanicos.FirstOrDefault(m=>m.Id== idMecanico);
        }
        
        public void EditarMecanico(Mecanico mecanicoNuevo)
        {
           var mecanicoActual= this.dbContext.Mecanicos.FirstOrDefault(m=>m.Id== mecanicoNuevo.Id);
           if (mecanicoActual != null){
                mecanicoActual.Nombre= mecanicoNuevo.Nombre;
                mecanicoActual.FechaNacimiento= mecanicoNuevo.FechaNacimiento;
                mecanicoActual.Telefono= mecanicoNuevo.Telefono;
                mecanicoActual.Contraseña= mecanicoNuevo.Contraseña;
                mecanicoActual.Rol= mecanicoNuevo.Rol;
           }
           this.dbContext.SaveChanges(); 
          }

           public void EliminarMecanico(string idMecanico)
        {
            
            var mecanicoEncontrado = this.dbContext.Mecanicos.FirstOrDefault(m=>m.Id== idMecanico);
             if (mecanicoEncontrado != null){

                this.dbContext.Remove(mecanicoEncontrado);
                this.dbContext.SaveChanges();

             }
        }
    }
}