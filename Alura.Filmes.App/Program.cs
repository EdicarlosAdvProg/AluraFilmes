using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Dados;
using System.Linq;
using Alura.Filmes.App.Negocio;
using System;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App {
    class Program {
        static void Main(string[] args) {

            using (var context = new AluraFilmesContexto()) {

                context.LogSQLToConsole();

                var filme = new Filme();
                filme.Titulo = "Senhor do Aneis";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = "Qualquer";
                filme.IdiomaFalado = context.Idiomas.First();

                context.Filmes.Add(filme);
                context.SaveChanges();

            }
        }
    }
}