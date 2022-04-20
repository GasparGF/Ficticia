namespace Ficticia.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Genero { get; set; }
        public bool Estado { get; set; } 
        public bool Maneja { get; set; }
        public bool Lentes { get; set; }
        public bool Diabetico { get; set; }
        public bool Enfermedad { get; set; }
        public string? Cual { get; set; }

    }
}
