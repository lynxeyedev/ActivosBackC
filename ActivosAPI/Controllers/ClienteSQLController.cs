using ActivosAPI.Comunes.Clasess.Contratos.ClientesSQL;
using ActivosAPI.Dominio.ActivosSQL.Clientes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteSQLController : ControllerBase
    {
        private readonly ICrudService<ClienteSQLContract> _servicio;
        public ClienteSQLController(ICrudService<ClienteSQLContract> servicio)
        {
            _servicio = servicio;
        }
        [HttpPost]
        public async Task<IActionResult> TransferirClientes()
        {
            return Ok(await _servicio.createOneTime());
        }
    }
}
