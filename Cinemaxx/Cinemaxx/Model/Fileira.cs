namespace Cinemaxx.Model
{
    public class Fileira
    {
        public int ID { get; set; }
        public int SalaID { get; set; }
        public string Indentificador { get; set; }
        public int CadeirasDe { get; set; }
        public int CadeirasAte { get; set; }
        public bool pne { get; set; }
        public int PneDe { get; set; }
        public int PneAte { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
