namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    public class Provincias : IEntity
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
