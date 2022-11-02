using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PruebaArtistas.Data.Entidades
{
    public partial class PruebaArtistasContext : DbContext
    {
        public PruebaArtistasContext()
        {
        }

        public PruebaArtistasContext(DbContextOptions<PruebaArtistasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cantante> Cantantes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=PruebaArtistas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cantante>(entity =>
            {
                entity.ToTable("Cantante");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
