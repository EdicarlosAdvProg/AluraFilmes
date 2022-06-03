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

                Console.WriteLine("Clientes:");
                foreach(var cliente in context.Clientes) {
                    Console.WriteLine(cliente);
                }

                Console.WriteLine("\nFuncionários:");
                foreach(var func in context.Funcionarios) {
                    Console.WriteLine(func);
                }

            }
        }
    }
}