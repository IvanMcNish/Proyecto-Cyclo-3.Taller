using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {
        public string titulo{get;set;}="Ordenes pendientes por trabajar";
        public string titulo2{get;set;}="Gestion de Ordenes ";
        public string titulo4{get;set;}="Filtro Fechas";
        public string titulo5{get;set;}="Acciones";

        public List<Mecani> listaMecanicos = new List<Mecani>()  {
            new Mecani(){infoOrden="Mazda 3- Juan - AXQ789- Servicio Correctivo", fecha= "Electricista", tipo= "Barranquilla"},
            new Mecani(){infoOrden="Toyota supra- Carlos - AFR789- Servicio Correctivo", fecha= "Latonero", tipo= "Barrancabermeja"}
          
        };
          public List<MecaniDispo> listaMecanicosDispo = new List<MecaniDispo>()  {
            new MecaniDispo(){nombreTec="Juan Star", fecha= "AM", tipo= "Electricista"},
            new MecaniDispo(){nombreTec="Carlos Steel", fecha= "PM", tipo= "Latonero"}
          
        };
        public void OnGet()
        {
             
             this.listaMecanicos.Add(new Mecani(){infoOrden="Ford 3- Maria - AER789- Servicio Correctivo", fecha= "Latonero", tipo= "Barrancabermeja"});
        }
    }
        public class Mecani {
            public string infoOrden {get;set;}

            public string fecha {get;set;}
            public string tipo {get;set;}

            public Mecani()
            {

            }
            
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

