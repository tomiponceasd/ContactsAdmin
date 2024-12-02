namespace ContactAdmin.Models.Entities
{
    public class Contacto
    {
        public Guid Id { get; set; }
        public required string Nombre { get; set; }
        public string? Empresa { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }





    }
}
