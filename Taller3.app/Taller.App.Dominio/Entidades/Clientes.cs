using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio.Entidades
{
    public class Clientes:Persona
    {
        public string ClientesId {get;set;}

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        
    }
}