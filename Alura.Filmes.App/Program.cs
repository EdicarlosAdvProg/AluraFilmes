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

                foreach(var item in context.Elenco) {

                    var entidade = context.Entry(item);
                    var filmeId = entidade.Property("film_id").CurrentValue;
                    var actorId = entidade.Property("actor_id").CurrentValue;
                    var lastUpd = entidade.Property("last_update").CurrentValue;

                    Console.WriteLine($"Filme {filmeId}; Ator {actorId}; LastUpdate {lastUpd}");
                }

 
            }
        }
    }
}