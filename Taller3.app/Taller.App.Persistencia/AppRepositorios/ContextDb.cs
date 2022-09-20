using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Taller.App.Persistencia
{
    public class ContextDb :DbContext
    {
        public virtual DbSet<Mecanico> Mecanicos {get;set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try{
                optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-4.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=admintic;Password=Tallermintic4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                }
            catch{
                
                }
        }
    }
}