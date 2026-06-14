using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmaciaAPI.Controllers
{
    [Route("api/[controller]")] // Define que la ruta empieza por 'api/Medicamentos'
    [ApiController]
    public class MedicamentosController : ControllerBase
    {
        // Al poner [HttpGet] aquí, le dices que este método responde a GET api/Medicamentos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("La API de Farmacia está funcionando correctamente.");
        }
    }
}