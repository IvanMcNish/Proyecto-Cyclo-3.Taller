using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Mecanico;


namespace Taller.App.Persistencia.Repositorios
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;

        public RepositorioMecanico (ContextDb dbContext)
        {
            this.dbContext=dbContext;

        }

        public Mecanico AgregarMecanico (Mecanico m){

            var mecanicoNuevo = this.dbContext.Mecanicos.Add(m);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;

        }
    }
}