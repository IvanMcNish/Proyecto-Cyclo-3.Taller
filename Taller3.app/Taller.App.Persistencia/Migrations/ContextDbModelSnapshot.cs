﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taller.App.Persistencia;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    [DbContext(typeof(ContextDb))]
    partial class ContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Mecanico", b =>
                {
                    b.Property<string>("MecanicoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelEstudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MecanicoId");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Revision", b =>
                {
                    b.Property<string>("RevisionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MecacnicoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MecanicoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RevisionId");

                    b.HasIndex("MecanicoId");

                    b.ToTable("Revisiones");
                });

            modelBuilder.Entity("Taller.App.Dominio.Entidades.Revision", b =>
                {
                    b.HasOne("Taller.App.Dominio.Entidades.Mecanico", "mecanico")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mecanico");
                });
#pragma warning restore 612, 618
        }
    }
}
