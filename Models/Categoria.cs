namespace InventarioFarmaciaAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Medicamento>? Medicamentos { get; set; }
    }
}