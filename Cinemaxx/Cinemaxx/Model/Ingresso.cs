namespace Cinemaxx.Model
{
    public class Ingresso
    {
        public int ID { get; set; }
        public int cadeira { get; set; }
        public int FileiraID { get; set; }
        public int ProgramacaoID { get; set; }
        public int UsuarioID { get; set; }

        public virtual Fileira Fileira { get; set; }
        public virtual Programacao Programacao { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
