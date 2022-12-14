using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia
{
    public class RepositorioRevision
    {
        
        private readonly ContextDb dbContext;

        public RepositorioRevision (ContextDb dbContext)
        {
            this.dbContext=dbContext;

        }

        public Revision AgregarRevision (Revision r){

            var revisionNuevo = this.dbContext.Revisiones.Add(r);
            this.dbContext.SaveChanges();
            return revisionNuevo.Entity;

        }
    }
}