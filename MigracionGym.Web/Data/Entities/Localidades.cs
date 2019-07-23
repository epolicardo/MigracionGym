namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    public class Localidades : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
