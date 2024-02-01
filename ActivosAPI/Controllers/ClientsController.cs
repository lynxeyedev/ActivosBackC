using ActivosAPI.Comunes.Clasess.Contratos.Clientes;
using ActivosAPI.Dominio.Activos.General;
using ActivosAPI.Infraestructura.Repository.ActivosMySQL.General;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActivosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IActivosService<ClientsContract> _cServicio;
        public ClientsController(IActivosService<ClientsContract> cServicio)
        {
            _cServicio = cServicio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerClientes()
        {
            return Ok(await _cServicio.GetAllClients());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerClientePorId(int id)
        {
            return Ok(await _cServicio.GetClientsById(id));
        }
    }
}