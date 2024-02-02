using ActivosAPI.Infraestructura.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActivosAPI.Infraestructura.DataBase.Context
{
    public class ActivosSQLContext : DbContext
    {
        public ActivosSQLContext(DbContextOptions<ActivosSQLContext> options)
            : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        #region [dbSet]
        public virtual DbSet<ClienteSQLEntity> ClienteSQLEntity { get; set; }
        #endregion
    }
}
