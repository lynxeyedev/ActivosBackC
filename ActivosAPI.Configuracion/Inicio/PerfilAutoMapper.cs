using ActivosAPI.Comunes.Clasess.Contratos.Clientes;
using ActivosAPI.Infraestructura.DataBase.Entity;
using AutoMapper;

namespace ActivosAPI.Configuracion.Inicio
{
    internal class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper() 
        {
            CreateMap<ClientsEntity, ClientsContract>().ReverseMap();
        }
        
    }
}
