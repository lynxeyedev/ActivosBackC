using ActivosAPI.Infraestructura.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActivosAPI.Infraestructura.DataBase.Context
{
    public class ActivosContext : DbContext
    {
        public ActivosContext(DbContextOptions<ActivosContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        #region [DBSets]
        public virtual DbSet<ClientsEntity> Clients { get; set; }
        public virtual DbSet<ContactEntity> Contact { get; set; }
        #endregion
    }
}
