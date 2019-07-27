namespace MigracionGym.Web.Data.Entities
{
using MigracionGym.Data.Entities;

    public class ParametrosSistema : IEntity
    {
        public int Id { get; set; }
        public string parametro { get; set; }
        public int valor { get; set; }
        public string valorString { get; set; }
    }
}
