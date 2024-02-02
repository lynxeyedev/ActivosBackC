namespace ActivosAPI.Comunes.Clasess.Contratos.ClientesSQL
{
    public class ClienteSQLContract
    {
        public int idCliente { get; set; }
        public string? cliente { get; set; }
        public string? cif { get; set; }
        public string? provincia { get; set; }
        public string? ciudad { get; set; }
        public string? cp { get; set; }
        public string? telefono { get; set; }
        public string? email { get; set; }
    }
}
