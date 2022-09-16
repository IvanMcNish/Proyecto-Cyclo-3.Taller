
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
            Console.WriteLine("");
           // AgregarMecanico();
           //ObtenerMecanicos();
           BuscarMecanico();
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                Id = "23",
                Nombre = "juan",
                FechaNacimiento = "",
                NivelEstudio = "bachiller",
                Telefono = "123",
                Contraseña = "123",
                Rol = "jefeoperaciones",
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
            }
        }
        static void BuscarMecanico(){
           repoMecanico.BuscarMecanico("26");
        }
    }



}