using MigracionGym.Data;

namespace MigracionGym.Web.Data.Entities
{
    public class Socios : IEntity
    {
        public int id { get; set; }
        public Personas personas { get; set; }
        public Domicilios domicilios { get; set; }
    }
}