using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Dominio.Entidades;
using Taller.App.Persistencia;

namespace Taller.App.Front.Pages
{
    public class RegistrarNuevoMecanicoModel : PageModel
    {
     private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );
        public string titulo{get;set;}="Ordenes pendientes por trabajar";
        public string titulo2{get;set;}="Gestion de Ordenes ";
        public string titulo4{get;set;}="Filtro Fechas";
        public string titulo5{get;set;}="Acciones";


        //lista de la tabla mecanicos
        public List<Mecani2> listaMecanicos = new List<Mecani2>()  ;
          
          
        
        public void OnGet()
        {
            //carga la tabla del repositorio automaticamente llamando el metodo, obtener mecanicos 
             this.ObtenerMecanicos();
        }
        private void ObtenerMecanicos()
        {

            //metodo para agregar mecanicos


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                this.listaMecanicos.Add(new Mecani2(){Cedula=mecanico.Id,NombreMec=mecanico.Nombre,fecha= mecanico.FechaNacimiento, Telefono= mecanico.Telefono, NivelDeEstudio= mecanico.Rol, Especialidad=mecanico.Contraseña});
                
            }
        }
    }
        
        //clase que se agrega en la tabla
        public class Mecani2 {
            public string NombreMec {get;set;}
            public string Cedula {get;set;}
            public string Telefono {get;set;}
            public string fecha {get;set;}
            public string NivelDeEstudio {get;set;}
            public string Especialidad {get;set;}

            public Mecani2()
            {

            }
            
        }
}

