using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Dados;
using System.Linq;
using Alura.Filmes.App.Negocio;
using System;
using Microsoft.EntityFrameworkCore;
using Alura.Filmes.App.Negocio.Enuns;

namespace Alura.Filmes.App {
    class Program {
        static void Main(string[] args) {

            using (var context = new AluraFilmesContexto()) {

                context.LogSQLToConsole();

                var filme = new Filme();
                filme.Titulo = "Cassino Royale";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = ClassificacaoIndicativa.MaioresQue14;
                filme.IdiomaFalado = context.Idiomas.First();
                context.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                context.Filmes.Add(filme);
                context.SaveChanges();

                var filmeInserido = context.Filmes.First(f => f.Titulo == "Cassino Royale");
                Console.WriteLine(filmeInserido.Classificacao);

            }
        }
    }
}