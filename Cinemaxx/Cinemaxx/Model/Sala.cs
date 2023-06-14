namespace Cinemaxx.Model
{
    public enum TipoSala
    {
        TD, DD, IMAX
    }
    public class Sala
    {
        public int ID { get; set; }
        public string Indentificador { get; set; }
        public int QuantidadeDeCadeiras { get; set; }
        public TipoSala TipoSala { get; set; }
        public bool Disponivel { get; set; }
        public int QtdPne { get; set; }

        public virtual ICollection<Fileira> Fileiras { get; set; }  
    }
}
