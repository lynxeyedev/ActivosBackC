using ActivosAPI.Infraestructura.DataBase.Context;
using ActivosAPI.Infraestructura.DataBase.Entity;
using ActivosAPI.Infraestructura.Repository.ActivosMySQL.General;
using Microsoft.EntityFrameworkCore;

namespace ActivosAPI.Infraestructura.Repository.ActivosMySQL.Clients
{
    public class ClientsRepository : IActivosRepository<ClientsEntity> 
    {
        private readonly ActivosContext _context;
        public ClientsRepository(ActivosContext context)
        {
            _context = context;
        }

        public async Task<List<ClientsEntity>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public Task<ClientsEntity> GetById(int id)
        {
            return _context.Clients.FirstOrDefaultAsync(c => c.id == id);
        }
    }
}
