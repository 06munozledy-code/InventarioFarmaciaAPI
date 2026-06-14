namespace InventarioFarmaciaAPI.DTOs
{
    public class MedicamentoDto
    {
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public int CategoriaId { get; set; }
    }
}
