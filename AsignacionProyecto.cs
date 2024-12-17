using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructoraUH.Models
{
    public class AsignacionProyecto
    {
        [Key]
        public int Id { get; set; }

        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleado Empleado { get; set; }

        public int ProyectoId { get; set; }
        [ForeignKey("ProyectoId")]
        public Proyecto Proyecto { get; set; }

        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
    }
}
