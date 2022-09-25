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

        public virtual DbSet<Revision> Revisiones {get;set;}

        public virtual DbSet<Cliente> Clientes {get;set;}

        public virtual DbSet<Vehiculo> Vehiculos {get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try{
                optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-4.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=admintic;Password=Tallermintic4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                
                }
            catch(System.Exception)
            {
                Console.WriteLine("Ocurrio un error en Onconfiguring");
                }
        }
    
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            //  modelBuilder.Entity<Revision>()
            // .HasOne(b => b.Mecanico)
            // .WithOne(i => i.Revision)
            // .HasForeignKey<Revision>(b => b.MecacnicoId);

        }
    }

}