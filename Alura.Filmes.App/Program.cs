﻿using Alura.Filmes.App.Extensions;
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

                var a = ClassificacaoIndicativa.Livre;
                string b = "PG-13";

                Console.WriteLine(a.ParaString());
                Console.WriteLine(b.ParaValor());

            }
        }
    }
}