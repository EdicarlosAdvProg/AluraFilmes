using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Dados;
using System.Linq;
using Alura.Filmes.App.Negocio;
using System;
using Microsoft.EntityFrameworkCore;
using Alura.Filmes.App.Negocio.Enuns;
using System.Data.SqlClient;

namespace Alura.Filmes.App {
    class Program {
        static void Main(string[] args) {

            using (var context = new AluraFilmesContexto()) {

                context.LogSQLToConsole();

                string categ = "Action";

                var paramCateg = new SqlParameter("category_name", categ);

                var paramTotal = new SqlParameter {
                    ParameterName = "@total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };

                context.Database
                    .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT",
                    paramCateg,
                    paramTotal);

                Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}");
                
            }
        }
    }
}