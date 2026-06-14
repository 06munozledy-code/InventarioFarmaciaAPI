using Microsoft.EntityFrameworkCore;
using InventarioFarmaciaAPI.Models;

namespace InventarioFarmaciaAPI.Data
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
    }
}
