﻿namespace ContactAdmin.Models
{
    public class UpdateContactDto
    {
        public required string Nombre { get; set; }
        public string? Empresa { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
    }
}
