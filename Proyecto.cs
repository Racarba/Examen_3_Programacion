using System.ComponentModel.DataAnnotations;

namespace ConstructoraUH.Models
{
    public class Proyecto
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }
    }
}
