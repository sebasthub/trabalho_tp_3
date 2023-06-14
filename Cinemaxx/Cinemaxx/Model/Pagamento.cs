using System.Data.SqlTypes;

namespace Cinemaxx.Model
{
    public enum FormaPagamento
    {
        PIX,BOLETO,DEBITO,CREDITO
    }
    public class Pagamento
    {
        public int Id { get; set; }
        public int IngressoID { get; set; }
        public string NomeFilme { get; set; }
        public int FilmeID { get; set; }
        public string Sala { get; set; }
        public string Fileira { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public SqlMoney valor { get; set; }

        public virtual Ingresso Ingresso { get; set; }
        public virtual Filme Filme { get; set; }

    }
}
