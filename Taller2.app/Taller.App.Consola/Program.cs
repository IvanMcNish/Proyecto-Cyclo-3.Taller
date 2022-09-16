
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
           ObtenerMecanicos();
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                id = "23",
                nombre = "juan",
                fechaNacimiento = "",
                nivelEstudio = "bachiller",
                telefono = "123",
                contraseña = "123",
                rol = "jefeoperaciones",
            };
            repoMecanico.AgregarMecanico(mecanico);
        }

        static void ObtenerMecanicos()
        {

            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                //Response.Write();
                Console.WriteLine(mecanico.nombre.ToString());
            }
        }
    }



}