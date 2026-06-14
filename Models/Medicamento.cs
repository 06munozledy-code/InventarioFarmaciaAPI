namespace InventarioFarmaciaAPI.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}