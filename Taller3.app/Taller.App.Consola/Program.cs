
using System;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;



namespace Taller.App.Consola
{

    class Program
    {
        private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );

        private static RepositorioCliente repoCliente = new RepositorioCliente(
         new Persistencia.ContextDb()


        );         
        private static RepositorioVehiculo repoVehiculo = new RepositorioVehiculo(
         new Persistencia.ContextDb()
        );
        static void Main(string[] args)
        {

            // AgregarMecanico();
            // ObtenerMecanicos();
            //BuscarMecanico();
            //EditarMecanico("23");
            //EliminarMecanico("25");

            //AgregarCliente();
            //ObtenerCliente();
            //BuscarCliente();
            //EditarCliente("1");
            //EliminarCliente("1");



            AgregarVehiculo();
            ObtenerVehiculos();
        }
        //--------------------- mecanicos --------------------------------------------------------------->
        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                MecanicoId = "1456789",
                Nombre = "kate",
                FechaNacimiento = "10/05/2021",
                NivelEstudio = "tecnico latoneria",
                Telefono = "12456789",
                Contraseña = "42345",
                Rol = "jefe operaciones2",
            };
            repoMecanico.AgregarMecanico(mecanico);
        }

        static void ObtenerMecanicos()
        {

            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                //Response.Write();
                Console.WriteLine(mecanico.Nombre.ToString());
                Console.WriteLine(mecanico.Telefono.ToString());
                Console.WriteLine(mecanico.Contraseña.ToString());
                Console.WriteLine(mecanico.Rol.ToString());
            }
        }
        static void BuscarMecanico()
        {
            var mecanico = repoMecanico.BuscarMecanico("29");
            Console.WriteLine("Prueba: " + mecanico.Nombre);
        }

        static void EditarMecanico(string Id)
        {
            var mecanico = new Mecanico
            {
                MecanicoId = "",
                Nombre = "carlos",
                FechaNacimiento = "15",
                NivelEstudio = "bachiller",
                Telefono = "123",
                Contraseña = "123",
                Rol = "jefeoperaciones",
            };



            repoMecanico.EditarMecanico(mecanico, Id);
        }

        static void EliminarMecanico(string Id)
        {

            repoMecanico.EliminarMecanico(Id);

        }
        //--------------------- clientes --------------------------------------------------------------->
        static void AgregarCliente()
        {
            var cliente = new Cliente
            {
                ClienteId = "1",
                Nombre = "pal mamonuo",
                FechaNacimiento = "10/05/2021",
                Direccion = "calle latoneria",
                Ciudad = "Bucara",
                Telefono = "12456789",
                Contraseña = "42345",
                Rol = "correo@taller.com",
            };
            repoCliente.AgregarCliente(cliente);
        }

        static void ObtenerCliente()
        {

            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());


            foreach (Cliente cliente in repoCliente.ObtenerCliente())
            {
                //Response.Write();
                Console.WriteLine(cliente.Nombre.ToString());
                Console.WriteLine(cliente.Telefono.ToString());
                Console.WriteLine(cliente.Contraseña.ToString());
                Console.WriteLine(cliente.Rol.ToString());
            }
        }

        static void BuscarCliente()
        {
            var cliente = repoCliente.BuscarCliente("1");
            Console.WriteLine("Prueba: " + cliente.Nombre);
        }
        static void EditarCliente(string Id)
        {
            var cliente = new Cliente
            {
                ClienteId = "",
                Nombre = "carlos",
                FechaNacimiento = "15",
                Direccion = " calle bachiller",
                Ciudad = " tabogo",
                Telefono = "123",
                Contraseña = "123",
                Rol = "jefeoperaciones@com.com",
            };



            repoCliente.EditarCliente(cliente, Id);
        }
        static void EliminarCliente(string Id)
        {

            repoCliente.EliminarCliente(Id);

        }
        //--------------------- vehiculos --------------------------------------------------------------->

        static void AgregarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                ID = "3",
                Marca = "ford",
                Modelo = "2021",
                Cilindraje = "12345cc",
                ClienteId = "2344",
                
            };
            repoVehiculo.AgregarVehiculo(vehiculo);
        }

        static void ObtenerVehiculos()
        {

           


            foreach (Vehiculo vehiculo in repoVehiculo.ObtenerVehiculos())
            {
                
                Console.WriteLine(vehiculo.ID.ToString());
                Console.WriteLine(vehiculo.Marca.ToString());
                Console.WriteLine(vehiculo.Modelo.ToString());
                Console.WriteLine(vehiculo.Cilindraje.ToString());
                Console.WriteLine(vehiculo.ClienteId.ToString());
            }
        }

        // static void BuscarCliente()
        // {
        //     var cliente = repoCliente.BuscarCliente("1");
        //     Console.WriteLine("Prueba: " + cliente.Nombre);
        // }
        // static void EditarCliente(string Id)
        // {
        //     var cliente = new Cliente
        //     {
        //         ClienteId = "",
        //         Nombre = "carlos",
        //         FechaNacimiento = "15",
        //         Direccion = " calle bachiller",
        //         Ciudad = " tabogo",
        //         Telefono = "123",
        //         Contraseña = "123",
        //         Rol = "jefeoperaciones@com.com",
        //     };



        //     repoCliente.EditarCliente(cliente, Id);
        // }
         static void EliminarVehiculo(string Id)
        {

            repoVehiculo.EliminarVehiculo(Id);

        }




    }



}