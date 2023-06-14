namespace Cinemaxx.Model
{
    public class Programacao
    {
        public int Id { get; set; }
        public int SalaID { get; set; }
        public int FilmeID { get; set; }
        public TimeOnly Horario { get; set; }

        public virtual Sala Sala { get; set; }
        public virtual Filme Filme { get; set; }
    }
}
