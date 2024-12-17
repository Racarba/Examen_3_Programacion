using System.ComponentModel.DataAnnotations;

namespace ConstructoraUH.Models
{
    public class Empleado
    {
        [Key]
        public int CarnetUnico { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; } = "San José";

        [Required]
        public string Telefono { get; set; }

        [Required, EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required, Range(250000, 500000)]
        public decimal Salario { get; set; } = 250000;

        [Required]
        public string Categoria { get; set; }
    }
}
