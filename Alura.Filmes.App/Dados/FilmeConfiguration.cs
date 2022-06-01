﻿using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados {
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme> {
        public void Configure(EntityTypeBuilder<Filme> builder) {

            builder
                .ToTable("film");

            builder
                .Property(a => a.Id)
                .HasColumnName("film_id");

            builder
                .Property(a => a.Descricao)
                .HasColumnName("description");

            builder
                .Property(a => a.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(a => a.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder
                .Property(a => a.Duracao)
                .HasColumnName("length")
                .HasColumnType("samallint");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}