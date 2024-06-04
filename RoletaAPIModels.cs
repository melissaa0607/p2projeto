namespace RoletaAPI.Models
{
    public class Cupom
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public bool Resgatado { get; set; }
    }
}

namespace RoletaAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}