namespace ActivosAPI.Dominio.Activos.General
{
    public interface IActivosService<T>
    {
        Task<List<T>> GetAllClients();
        Task<T> GetClientsById(int id);
    }
}
