using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {
         private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );
        public string titulo{get;set;}="Ordenes pendientes por trabajar";
        public string titulo2{get;set;}="Gestion de Ordenes ";
        public string titulo4{get;set;}="Filtro Fechas";
        public string titulo5{get;set;}="Acciones";

        //lista de mecanicos a llenar
        public List<Mecani> listaMecanicos = new List<Mecani>()  ;



          public List<MecaniDispo> listaMecanicosDispo = new List<MecaniDispo>()  {
            new MecaniDispo(){nombreTec="Juan Star", fecha= "AM", tipo= "Electricista"},
            new MecaniDispo(){nombreTec="Carlos Steel", fecha= "PM", tipo= "Latonero"}
          
        };
        public void OnGet()
        {
             
             this.ObtenerMecanicos();
        }
        private void ObtenerMecanicos()
        {

            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                this.listaMecanicos.Add(new Mecani(){TRol=mecanico.MecanicoId,infoOrden=mecanico.Nombre, fecha= mecanico.Telefono, tipo= mecanico.Rol});
                
            }
        }
    }
        public class Mecani {
            public string TRol {get;set;}
            public string infoOrden {get;set;}

            public string fecha {get;set;}
            public string tipo {get;set;}

       
            
        }
        public class MecaniDispo {
            public string nombreTec {get;set;}

            public string fecha {get;set;}
            public string tipo {get;set;}

            public MecaniDispo()
            {

            }
            
        }
    }

