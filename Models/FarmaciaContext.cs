using Microsoft.EntityFrameworkCore;

namespace InventarioFarmaciaAPI.Models
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options) { }

        public DbSet<Medicamento> Medicamentos { get; set; }
    }
}
