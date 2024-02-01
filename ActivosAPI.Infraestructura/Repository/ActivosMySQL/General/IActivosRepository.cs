namespace ActivosAPI.Infraestructura.Repository.ActivosMySQL.General
{
    public interface IActivosRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
