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

                Ator ator = new Ator() { PrimeiroNome = "Emma", UltimoNome = "Watson" };

                context.Atores.Add(ator);

                context.SaveChanges();

            }
        }
    }
}