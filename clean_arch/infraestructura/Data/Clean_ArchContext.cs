using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Core.entidades;

namespace infraestructura.Data
{
    public partial class Clean_ArchContext : DbContext
    {
        public Clean_ArchContext()
        {
        }

        public Clean_ArchContext(DbContextOptions<Clean_ArchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FacturaEntidad> Facturas { get; set; }
        public virtual DbSet<VehiculoEntidad> Vehiculos { get; set; }
        public virtual DbSet<ClienteEntidad> Clientes { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacturaEntidad>(entity =>
            {
                entity.HasKey(e => e.Idfactura);

                entity.Property(e => e.Idfactura).ValueGeneratedNever();

                entity.Property(e => e.matricula)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);

                entity.HasKey(e => e.Idcliente);

                entity.Property(e => e.Idcliente).ValueGeneratedNever();


                entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                //entity.HasOne(d => d.Idfactura)
                entity.HasOne(d => d.Vehiculo)
                  .WithMany(p => p.Facturas)
                  .HasForeignKey(d => d.matricula)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_factura_vehiculo");

                entity.HasOne(d => d.cliente)
                 .WithMany(p => p.Facturas)
                 .HasForeignKey(d => d.Idcliente)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_factura_cliente");



            });
            modelBuilder.Entity<VehiculoEntidad>(entity =>
            {
                entity.HasKey(e => e.matricula);

                entity.Property(e => e.matricula).ValueGeneratedNever();

                entity.Property(e => e.matricula)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);

                entity.HasKey(e => e.Idcliente);

                entity.Property(e => e.Idcliente).ValueGeneratedNever();


                entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            }); 
            
            modelBuilder.Entity<ClienteEntidad>(entity =>
            {
                entity.HasKey(e => e.Idcliente);

                entity.Property(e => e.Idcliente).ValueGeneratedNever();

                entity.Property(e => e.Nombres)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Fechaingreso).HasColumnType("datetime");

                entity.Property(e => e.Telefono)
               .IsRequired()
               .HasMaxLength(12)
               .IsUnicode(false);
            });
        }
    }
}
