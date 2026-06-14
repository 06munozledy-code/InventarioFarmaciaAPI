using Microsoft.AspNetCore.Mvc;

namespace InventarioFarmaciaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicamentosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerMedicamentos()
        {
            return Ok("Lista de medicamentos");
        }
    }
}
