using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;


namespace Taller.App.Front.Pages
{
    public class RegistroClienteModel : PageModel

    {
         private static RepositorioCliente repoCliente = new RepositorioCliente(
            new Persistencia.ContextDb()
        );
        public List<Cliente> ListaCliente = new List<Cliente>()  ;
        public void OnGet()
        {
            this.ObtenerCliente();
        }
         public void OnPostAdd(Cliente cliente )
        {   try
            {

            repoCliente.AgregarCliente(cliente);
            this.ObtenerCliente();
            }
            catch(System.Exception)
            {
                
                throw;
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
