
using System;
using Taller.App.Persistencia;
using Taller.App.Dominio;
namespace Taller.App.Consola{

    class Program{
        private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );

        static void Main (string[] args)
        {
            Console.WriteLine("");

        }

        static void AgregarMecanico(){
            var mecanico = new Mecanico {
                id="23",
                nombre="juan",
                fechaNacimiento="",
                nivelEstudio="bachiller",
                telefono="123",
                contrasenia="123",
                rol="jefeoperaciones",
            };
        }
    }



}