using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Dados;
using System.Linq;

namespace Alura.Filmes.App {
    class Program {
        static void Main(string[] args) {

            using(var context=new AluraFilmesContexto()) {
                
                context.LogSQLToConsole();
               
                foreach(var item in context.Atores) {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}