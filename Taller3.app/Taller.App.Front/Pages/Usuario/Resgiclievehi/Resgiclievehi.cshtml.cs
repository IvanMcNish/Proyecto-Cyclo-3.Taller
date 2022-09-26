using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages
{
    public class ResgiclievehiModel : PageModel
    {
    private static RepositorioVehiculo repoVehiculo = new RepositorioVehiculo(
            new Persistencia.ContextDb()
              );
            private static RepositorioCliente repoCliente = new RepositorioCliente(
            new Persistencia.ContextDb()
            );
      
        public List<Cliente> ListaCliente = new List<Cliente>()  ;

        //lista de la tabla mecanicos
        public List<Vehiculo> listaVehiculos = new List<Vehiculo>()  ;
          
          
        
        public void OnGet()
        {
            //carga la tabla del repositorio automaticamente llamando el metodo, obtener mecanicos 
             this.ObtenerVehiculos();
            this.ObtenerCliente();

        }

        public void OnPostAdd(Vehiculo vehiculo )
        {   try
            {

            repoVehiculo.AgregarVehiculo(vehiculo);
            this.ObtenerVehiculos();
            this.ObtenerCliente();
            }
            catch(System.Exception)
            {
             
                throw;
            }
        }

        public void OnPostDelete(string ID )
        {   try
            {

            repoVehiculo.EliminarVehiculo(ID);
            this.ObtenerVehiculos();
            this.ObtenerCliente();
            }
            catch(System.Exception)
            {
                
                throw;
            }
        }

        private void ObtenerVehiculos()
        {

            //metodo para agregar mecanicos


            foreach (Vehiculo vehiculo in repoVehiculo.ObtenerVehiculos())
            {
                this.listaVehiculos.Add(new Vehiculo()
                {
                    ID=vehiculo.ID,
                    Marca=vehiculo.Marca,
                    Modelo= vehiculo.Modelo,
                    Cilindraje= vehiculo.Cilindraje, 
                    ClienteId= vehiculo.ClienteId 
                   
                    });                
            }
        }
      
        

        
        private void ObtenerCliente()
        {

            //metodo para agregar mecanicos


            foreach (Cliente cliente in repoCliente.ObtenerCliente())
            {
                this.ListaCliente.Add(new Cliente()
                {
                    ClienteId=cliente.ClienteId,
                    Direccion=cliente.Direccion,
                    Ciudad=cliente.Ciudad,
                    Nombre=cliente.Nombre,
                    Telefono= cliente.Telefono, 
                    FechaNacimiento= cliente.FechaNacimiento,
                    Contraseña=cliente.Contraseña,
                    Rol= cliente.Rol


                    }
                    );                
            }
        }
    }
}
