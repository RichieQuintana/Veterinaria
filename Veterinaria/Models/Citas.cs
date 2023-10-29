using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Models
{
    public class Citas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de la cita es obligatoria.")]
        public DateTime Fecha { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public int MascotaId { get; set; }

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }
    }
}
