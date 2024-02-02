using ActivosAPI.Comunes.Clasess.Contratos.ClientesSQL;
using ActivosAPI.Dominio.ActivosSQL.Clientes;
using ActivosAPI.Infraestructura.DataBase.Entity;
using ActivosAPI.Infraestructura.Repository.ActivosMySQL.General;
using ActivosAPI.Infraestructura.Repository.ActivosSQL.General;
using AutoMapper;

namespace ActivosAPI.Dominio.ActivosSQL.General
{
    public class ClienteService : ICrudService<ClienteSQLContract>
    {
        private readonly ICrudRepository<ClienteSQLEntity> _csqlRepo;
        private readonly IActivosRepository<ClientsEntity> _cmysqlRepo;
        private readonly IMapper _mapper;
        public ClienteService(ICrudRepository<ClienteSQLEntity> csqlRepo, IActivosRepository<ClientsEntity> cmysqlRepo, IMapper mapper)
        {
            _csqlRepo = csqlRepo;
            _cmysqlRepo = cmysqlRepo;
            _mapper = mapper;
        }

        public async Task<List<ClienteSQLContract>> createOneTime()
        {
            List<ClientsEntity> clientsMySQL = await _cmysqlRepo.GetAll();
            foreach (ClientsEntity client in clientsMySQL) 
            {
                ClienteSQLEntity cliente = new ClienteSQLEntity()
                {
                    cliente = client.NOMBRE1,
                    cif = client.NIF,
                    provincia = client.CIUDAD2,
                    ciudad = client.CIUDAD,
                    cp = client.CP,
                    telefono = client.TELEFONO,
                    email = client.EMAIL,
                };
                await _csqlRepo.Insert(cliente);
            }
            List<ClienteSQLEntity> clientesSQL = await _csqlRepo.GetAll();
            return _mapper.Map<List<ClienteSQLContract>>(clientesSQL);
        }

        public async Task<List<ClienteSQLContract>> GetAll()
        {
            List<ClienteSQLEntity> clientesSQL = await _csqlRepo.GetAll();
            return _mapper.Map<List<ClienteSQLContract>>(clientesSQL);
        }
    }
}
