using ActivosAPI.Infraestructura.DataBase.Context;
using ActivosAPI.Infraestructura.DataBase.Entity;
using ActivosAPI.Infraestructura.Repository.ActivosSQL.General;
using Microsoft.EntityFrameworkCore;

namespace ActivosAPI.Infraestructura.Repository.ActivosSQL.Cliente
{
    public class ClienteSQLRepository : ICrudRepository<ClienteSQLEntity>
    {
        private readonly ActivosSQLContext _context;
        public ClienteSQLRepository(ActivosSQLContext context)
        {
            _context = context;
        }

        public async Task<List<ClienteSQLEntity>> GetAll()
        {
            return await _context.ClienteSQLEntity.ToListAsync();
        }

        public async Task<ClienteSQLEntity> GetById(int id)
        {
            return await _context.ClienteSQLEntity
                .FirstOrDefaultAsync(c => c.idCliente == id);
        }

        public async Task<ClienteSQLEntity> Insert(ClienteSQLEntity entity)
        {
            _context.ClienteSQLEntity.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        
    }
}
