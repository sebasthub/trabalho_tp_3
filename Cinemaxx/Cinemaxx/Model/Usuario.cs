namespace Cinemaxx.Model
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public bool Administrador { get; set; }

        public virtual ICollection<Ingresso> Ingressos { get; set; }
    }
}
