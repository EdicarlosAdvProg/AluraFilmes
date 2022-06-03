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

                string sql = @"SELECT a.*, f.c FROM actor a INNER JOIN
(SELECT TOP(5) a.actor_id, COUNT(*) AS c 
FROM actor a INNER JOIN film_actor fa ON a.actor_id = fa.actor_id
GROUP BY a.actor_id
ORDER BY c DESC) f On a.actor_id = f.actor_id";

                var atoresMaisAtuantes = context.Atores.FromSql(sql)
                    .Include(a=>a.Filmes);
                    
                foreach(var ator in atoresMaisAtuantes) {
                    Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmes.Count} filmes");
                }
                
            }
        }
    }
}