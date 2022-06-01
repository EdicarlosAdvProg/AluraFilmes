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

                var idiomas=context.Idiomas
                    .Include(i => i.FilmesFalados);

                foreach(var item in idiomas) {
                    
                    Console.WriteLine(item);

                    foreach(var filme in item.FilmesFalados) {
                        Console.WriteLine(filme);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}