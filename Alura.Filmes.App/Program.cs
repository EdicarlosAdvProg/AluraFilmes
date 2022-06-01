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

                var filme = context.Filmes
                    .Include(f=>f.Atores)
                    .ThenInclude(fa=>fa.Ator)
                    .First();

                Console.WriteLine(filme);
                Console.WriteLine("Elenco:");

                foreach(var item in filme.Atores) {
                    Console.WriteLine(item.Ator);
                }
            }
        }
    }
}