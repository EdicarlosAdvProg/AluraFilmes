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

                string sql = @"SELECT a.* FROM actor a INNER JOIN
                            top5_most_starred_actors f On a.actor_id = f.actor_id";

                var atoresMaisAtuantes = context.Atores.FromSql(sql)
                    .Include(a=>a.Filmes);
                    
                foreach(var ator in atoresMaisAtuantes) {
                    Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmes.Count} filmes");
                }
                
            }
        }
    }
}