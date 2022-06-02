
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio.Enuns;
using System.Collections.Generic;

namespace Alura.Filmes.App.Negocio {
    public class Filme {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificação { get; set; }      //propriedade usada na relação de banco de dados
        public ClassificacaoIndicativa Classificacao {      //propriedade usada na Orientação a Objeto
            get { return TextoClassificação.ParaValor(); } 
            set { TextoClassificação=value.ParaString(); } 
        }
        public IList<FilmeAtor> Atores { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }

        public Filme() {
            Atores = new List<FilmeAtor>();
        }

        public override string ToString() {
            return $"Filme ({Id}): {Titulo} - {AnoLancamento}";
        }
    }
}
