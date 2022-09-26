using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia
{
   
    public class RepositorioVehiculo
    {
        private readonly ContextDb dbContext;

        public RepositorioVehiculo (ContextDb dbContext)
        {
            this.dbContext=dbContext;

        }

        public Vehiculo AgregarVehiculo (Vehiculo v){

            var vehiculoNuevo = this.dbContext.Vehiculos.Add(v);
            this.dbContext.SaveChanges();
            return vehiculoNuevo.Entity;
        

        }

        public IEnumerable<Vehiculo> ObtenerVehiculos()
        {
            return this.dbContext.Vehiculos;
        }

        public Vehiculo BuscarVehiculo(string idVehiculo)
        {
            
            return this.dbContext.Vehiculos.FirstOrDefault(m=>m.ID== idVehiculo);
        }
        
        public void EditarVehiculo(Vehiculo vehiculoNuevo, string Id)
        {
           var vehiculoActual= this.dbContext.Vehiculos.FirstOrDefault(v=>v.ID== Id);
           if (vehiculoActual != null){
                vehiculoActual.Marca= vehiculoNuevo.Marca;
                vehiculoActual.Modelo= vehiculoNuevo.Modelo;
                vehiculoActual.Cilindraje= vehiculoNuevo.Cilindraje;
                vehiculoActual.ClienteId= vehiculoNuevo.ClienteId;
              
                this.dbContext.SaveChanges(); 
           }
          }

           public void EliminarVehiculo(string idVehiculo)
        {
            
            var vehiculoEncontrado = this.dbContext.Vehiculos.FirstOrDefault(v=>v.ID== idVehiculo);
             if (vehiculoEncontrado != null){

                this.dbContext.Remove(vehiculoEncontrado);
                this.dbContext.SaveChanges();

             }
        }
    }
        
    
}