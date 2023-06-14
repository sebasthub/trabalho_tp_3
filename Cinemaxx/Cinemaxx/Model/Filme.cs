using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data.SqlTypes;

namespace Cinemaxx.Model
{
    public class Filme
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public TimeOnly Duracao { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Idioma { get; set; }
        public bool Legenda { get; set; }
        public bool Novo { get; set; }
        public SqlMoney preco { get; set; }
    }
}
