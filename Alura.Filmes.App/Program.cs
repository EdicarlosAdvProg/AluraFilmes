using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Dados;
using System.Linq;
using Alura.Filmes.App.Negocio;
using System;

namespace Alura.Filmes.App {
    class Program {
        static void Main(string[] args) {

            using(var context=new AluraFilmesContexto()) {
                
                context.LogSQLToConsole();

                var actor = new Ator();
                actor.PrimeiroNome = "Tom";
                actor.UltimoNome = "Hanks";

                //context.Entry(actor)
                //    .Property("last_update")
                //    .CurrentValue = DateTime.Now;

                context.Atores.Add(actor);
                context.SaveChanges();
            }
        }
    }
}