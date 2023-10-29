using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especie de la mascota es obligatoria.")]
        [StringLength(50)]
        public string Especie { get; set; }

        [Range(0, 20, ErrorMessage = "La edad debe estar entre 0 y 20 años.")]
        public int Edad { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Dueño { get; set; }
    }
}
