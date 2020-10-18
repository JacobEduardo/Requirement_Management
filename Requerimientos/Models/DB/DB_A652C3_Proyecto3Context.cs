using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Requerimientos.Models.BD
{
    public partial class DB_A652C3_Proyecto3Context : DbContext
    {
        public DB_A652C3_Proyecto3Context()
        {
        }

        public DB_A652C3_Proyecto3Context(DbContextOptions<DB_A652C3_Proyecto3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Foro> Foro { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Mensaje> Mensaje { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<TecnicoArl> TecnicoArl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data source=sql5052.site4now.net; Initial Catalog=DB_A652C3_Proyecto3; user id=DB_A652C3_Proyecto3_admin; password=Requerimiento1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PK_event");

                entity.ToTable("EVENT");

                entity.Property(e => e.IdEvent).HasColumnName("ID_EVENT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Foro>(entity =>
            {
                entity.HasKey(e => e.IdForo)
                    .HasName("PK_foro");

                entity.ToTable("FORO");

                entity.HasIndex(e => e.IdRequest)
                    .HasName("fkIdx_70");

                entity.Property(e => e.IdForo).HasColumnName("ID_FORO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("text");

                entity.Property(e => e.IdRequest).HasColumnName("ID_REQUEST");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRequestNavigation)
                    .WithMany(p => p.Foro)
                    .HasForeignKey(d => d.IdRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_70");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(e => e.IdHistory)
                    .HasName("PK_history");

                entity.ToTable("HISTORY");

                entity.HasIndex(e => e.IdEvent)
                    .HasName("fkIdx_43");

                entity.HasIndex(e => e.IdRequest)
                    .HasName("fkIdx_14");

                entity.HasIndex(e => e.IdTecnicoArl)
                    .HasName("fkIdx_35");

                entity.Property(e => e.IdHistory)
                    .HasColumnName("ID_HISTORY")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EventMessage)
                    .IsRequired()
                    .HasColumnName("EVENT_MESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.IdEvent).HasColumnName("ID_EVENT");

                entity.Property(e => e.IdRequest).HasColumnName("ID_REQUEST");

                entity.Property(e => e.IdTecnicoArl).HasColumnName("ID_TECNICO_ARL");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.History)
                    .HasForeignKey(d => d.IdEvent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_43");

                entity.HasOne(d => d.IdRequestNavigation)
                    .WithMany(p => p.History)
                    .HasForeignKey(d => d.IdRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_14");

                entity.HasOne(d => d.IdTecnicoArlNavigation)
                    .WithMany(p => p.History)
                    .HasForeignKey(d => d.IdTecnicoArl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_35");
            });

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.HasKey(e => e.IdMensaje)
                    .HasName("PK_mensaje");

                entity.ToTable("MENSAJE");

                entity.HasIndex(e => e.IdForo)
                    .HasName("fkIdx_63");

                entity.HasIndex(e => e.IdTecnicoArl)
                    .HasName("fkIdx_73");

                entity.Property(e => e.IdMensaje)
                    .HasColumnName("ID_MENSAJE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("BODY")
                    .HasColumnType("text");

                entity.Property(e => e.IdForo).HasColumnName("ID_FORO");

                entity.Property(e => e.IdTecnicoArl).HasColumnName("ID_TECNICO_ARL");

                entity.HasOne(d => d.IdForoNavigation)
                    .WithMany(p => p.Mensaje)
                    .HasForeignKey(d => d.IdForo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_63");

                entity.HasOne(d => d.IdTecnicoArlNavigation)
                    .WithMany(p => p.Mensaje)
                    .HasForeignKey(d => d.IdTecnicoArl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_73");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.IdRequest)
                    .HasName("PK_requerimiento");

                entity.ToTable("REQUEST");

                entity.Property(e => e.IdRequest).HasColumnName("ID_REQUEST");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("BODY")
                    .HasColumnType("text");

                entity.Property(e => e.Foster)
                    .IsRequired()
                    .HasColumnName("FOSTER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(180)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TecnicoArl>(entity =>
            {
                entity.HasKey(e => e.IdTecnicoArl)
                    .HasName("PK_tecnico_arl");

                entity.ToTable("TECNICO_ARL");

                entity.Property(e => e.IdTecnicoArl).HasColumnName("ID_TECNICO_ARL");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("APELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasColumnName("CARGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
