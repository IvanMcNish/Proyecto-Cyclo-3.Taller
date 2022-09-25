using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Vehiculo
    {   
        public string ID {get; set;}
        public string Marca { get; set; }
        public string Modelo { get; set; }
       
        public string Cilindraje { get; set; }

        public string ClienteId { get; set; }
    }
}