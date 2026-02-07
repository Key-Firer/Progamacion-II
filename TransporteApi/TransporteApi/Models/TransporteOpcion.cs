using Microsoft.AspNetCore.Mvc;
using TransporteApi.Models;

namespace TransporteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransporteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var ejemplo = new TransporteOpcion
            {
                Id = 1,
                Medio = "Uber",
                DistanciaKm = 10,
                CostoEstimado = 300
            };

            return Ok(ejemplo);
        }
    }
}
