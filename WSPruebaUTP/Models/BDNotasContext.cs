using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WSPruebaUTP.Models
{
    public partial class BDNotasContext : DbContext
    {
        public BDNotasContext()
        {
        }

        public BDNotasContext(DbContextOptions<BDNotasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nota> Nota { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HOSUMK2;Database=BDNotas;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Nota>(entity =>
            {
                entity.ToTable("nota");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Nota1)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("nota1");

                entity.Property(e => e.Nota2)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("nota2");

                entity.Property(e => e.Nota3)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("nota3");

                entity.Property(e => e.Nota4)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("nota4");

                entity.Property(e => e.Promedio)
                    .HasColumnType("decimal(3, 1)")
                    .HasColumnName("promedio");

               entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_nota_usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
