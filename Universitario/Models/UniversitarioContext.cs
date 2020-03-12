using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Universitario.Models
{
    public partial class UniversitarioContext : DbContext
    {
        public UniversitarioContext()
        {
        }

        public UniversitarioContext(DbContextOptions<UniversitarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AQ9ABPJ;Database=Universitario;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Estudiantes>(entity =>
            {
                entity.HasKey(e => e.IdEstudiante)
                    .HasName("PK__Estudian__B5007C24B7432442");

                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Carrera).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });
        }
    }
}
