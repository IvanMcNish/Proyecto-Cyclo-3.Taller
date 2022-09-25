using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia
{
    public class RepositorioCliente
    {
        private readonly ContextDb dbContext;

        public RepositorioCliente(ContextDb dbContext)
        {
            this.dbContext = dbContext;

        }

        public Cliente AgregarCliente(Cliente c)
        {

            var clienteNuevo = this.dbContext.Clientes.Add(c);
            this.dbContext.SaveChanges();
            return clienteNuevo.Entity;

        }

        public IEnumerable<Cliente> ObtenerCliente()
        {
            return this.dbContext.Clientes;
        }
        public Cliente BuscarCliente(string idCliente)
        {

            return this.dbContext.Clientes.FirstOrDefault(c => c.ClienteId == idCliente);
        }
        public void EditarCliente(Cliente clienteNuevo, string Id)
        {
            var clienteActual = this.dbContext.Clientes.FirstOrDefault(c => c.ClienteId == Id);
            if (clienteActual != null)
            {
                clienteActual.Nombre = clienteNuevo.Nombre;
                clienteActual.FechaNacimiento = clienteNuevo.FechaNacimiento;
                clienteActual.Telefono = clienteNuevo.Telefono;
                clienteActual.Ciudad = clienteNuevo.Ciudad;
                clienteActual.Direccion = clienteNuevo.Direccion;
                clienteActual.Contraseña = clienteNuevo.Contraseña;
                clienteActual.Rol = clienteNuevo.Rol;
                this.dbContext.SaveChanges();
            }
        }

        public void EliminarCliente(string idCliente)
        {

            var clienteEncontrado = this.dbContext.Clientes.FirstOrDefault(m => m.ClienteId == idCliente);
            if (clienteEncontrado != null)
            {

                this.dbContext.Remove(clienteEncontrado);
                this.dbContext.SaveChanges();

            }
        }

    }
}