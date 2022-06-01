using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados {
    public class AluraFilmesContexto : DbContext {

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            //MAPEAMENTO DA TABELA [actor]
            modelBuilder.Entity<Ator>()
                .ToTable("actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
                .Property(a => a.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();

            //MAPEAMENTO DA TABELA [film]
            modelBuilder.Entity<Filme>()
                .ToTable("film");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Id)
                .HasColumnName("film_id");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Descricao)
                .HasColumnName("description");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            modelBuilder.Entity<Filme>()
                .Property(a => a.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            modelBuilder.Entity<Filme>()
                .Property(a => a.Duracao)
                .HasColumnName("length")
                .HasColumnType("samallint");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder
                .UseSqlServer("Data Source=DESKTOP-H77C52F\\SQLEXPRESS;" +
                "Initial Catalog=AluraFilmes;" +
                "User ID=sa;Password=1a5w2s3d;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False;");
        }

    }
}
