
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

        static void Main(string[] args)
        {
            
           AgregarMecanico();
           //ObtenerMecanicos();
           //BuscarMecanico();
           //EditarMecanico("23");
           //EliminarMecanico("25");
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "1456789",
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
        static void BuscarMecanico(){
           var mecanico = repoMecanico.BuscarMecanico("29");
           Console.WriteLine("Prueba: " + mecanico.Nombre);
        }

        static void EditarMecanico(string Id){
            var mecanico = new Mecanico
            {
                Id = "",
                Nombre = "carlos",
                FechaNacimiento = "15",
                NivelEstudio = "bachiller",
                Telefono = "123",
                Contraseña = "123",
                Rol = "jefeoperaciones",
            };



            repoMecanico.EditarMecanico(mecanico, Id);
        }

        static void EliminarMecanico(string Id){
                
                repoMecanico.EliminarMecanico(Id);

        }
    }



}