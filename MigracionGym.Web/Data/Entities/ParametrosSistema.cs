namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class ParametrosSistema : IEntity
    {
        public int id { get; set; }
        public string parametro { get; set; }
        public int valor { get; set; }
        public string valorString { get; set; }
    }
}
