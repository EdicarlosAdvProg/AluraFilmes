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

                string sql = "INSERT INTO language (name) VALUES ('Language1'), ('Language2'), ('Language3')";
                var registros= context.Database.ExecuteSqlCommand(sql);
                Console.WriteLine($"O total de registros afetados é  {registros}");

                string deleteSQL = "DELETE FROM language WHERE name LIKE 'Language%'";
                registros = context.Database.ExecuteSqlCommand(deleteSQL);
                Console.WriteLine($"O total de registros afetados é  {registros}");


            }
        }
    }
}