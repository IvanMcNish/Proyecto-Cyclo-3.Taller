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
        public List<Mecanico> listaMecanicos = new List<Mecanico>()  ;
          
          
        
        public void OnGet()
        {
            //carga la tabla del repositorio automaticamente llamando el metodo, obtener mecanicos 
             this.ObtenerMecanicos();
        }

        public void OnPostAdd(Mecanico mecanico )
        {   try
            {

            repoMecanico.AgregarMecanico(mecanico);
            this.ObtenerMecanicos();
            }
            catch(System.Exception)
            {
             
                throw;
            }
        }

        public void OnPostDelete(string MecanicoId )
        {   try
            {

            repoMecanico.EliminarMecanico(MecanicoId);
            this.ObtenerMecanicos();
            }
            catch(System.Exception)
            {
                
                throw;
            }
        }

        private void ObtenerMecanicos()
        {

            //metodo para agregar mecanicos


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                this.listaMecanicos.Add(new Mecanico()
                {
                    MecanicoId=mecanico.MecanicoId,
                    Nombre=mecanico.Nombre,
                    FechaNacimiento= mecanico.FechaNacimiento,
                    Telefono= mecanico.Telefono, 
                    Rol= mecanico.Rol, 
                    Contraseña=mecanico.Contraseña
                    });                
            }
        }
    }
        
        //clase que se agrega en la tabla
       //public class Mecani2 {
           // public string NombreMec {get;set;}
            //public string Cedula {get;set;}
           // public string Telefono {get;set;}
           // public string fecha {get;set;}
           // public string NivelDeEstudio {get;set;}
          //  public string Especialidad {get;set;}

          //  public Mecani2()
          //  {

            //}
            
       // }
}

