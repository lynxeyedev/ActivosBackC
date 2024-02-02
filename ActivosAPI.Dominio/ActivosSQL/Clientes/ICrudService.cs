namespace ActivosAPI.Dominio.ActivosSQL.Clientes
{
    public interface ICrudService<T>
    {
        Task<List<T>> createOneTime();
        Task<List<T>> GetAll();
    }
}
