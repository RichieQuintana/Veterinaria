using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Range(0, 30)]
        public string Telefono { get; set; }

        public List<Mascota> Mascotas { get; set; }
    }
}
