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

                var atores = context.Atores
                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);

                foreach (var a in atores) {
                    Console.WriteLine(a + " - " + context.Entry(a).Property("last_update").CurrentValue);
                }
            }
        }
    }
}