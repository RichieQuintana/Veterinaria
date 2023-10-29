using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;

namespace Veterinaria.Data
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext (DbContextOptions<VeterinariaContext> options)
            : base(options)
        {
        }

        public DbSet<Veterinaria.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<Veterinaria.Models.Citas>? Citas { get; set; }

        public DbSet<Veterinaria.Models.Mascota>? Mascota { get; set; }
    }
}
