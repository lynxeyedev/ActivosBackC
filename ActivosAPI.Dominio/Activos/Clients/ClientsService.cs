using ActivosAPI.Comunes.Clasess.Contratos.Clientes;
using ActivosAPI.Dominio.Activos.General;
using ActivosAPI.Infraestructura.DataBase.Entity;
using ActivosAPI.Infraestructura.Repository.ActivosMySQL.General;
using AutoMapper;

namespace ActivosAPI.Dominio.Activos.Clients
{
    public class ClientsService : IActivosService<ClientsContract>
    {
        private readonly IActivosRepository<ClientsEntity> _aRepository;
        private readonly IMapper _mapper;
        public ClientsService(IActivosRepository<ClientsEntity> aRepository, IMapper mapper)
        {
            _aRepository = aRepository;
            _mapper = mapper;
        }

        public async Task<List<ClientsContract>> GetAllClients()
        {
            List<ClientsEntity> listaClientes = await _aRepository.GetAll();
            return _mapper.Map<List<ClientsContract>>(listaClientes);
        }

        public async Task<ClientsContract> GetClientsById(int id)
        {
            ClientsEntity cliente = await _aRepository.GetById(id);
            if (cliente != null) 
            {
                return _mapper.Map<ClientsContract>(cliente);
            }
            else
            {
                return new ClientsContract();
            }

        }
    }
}
