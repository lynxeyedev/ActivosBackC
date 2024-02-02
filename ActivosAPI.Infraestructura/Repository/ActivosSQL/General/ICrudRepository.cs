namespace ActivosAPI.Infraestructura.Repository.ActivosSQL.General
{
    public interface ICrudRepository<T>
    {
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task<List<T>> GetAll();
    }
}
