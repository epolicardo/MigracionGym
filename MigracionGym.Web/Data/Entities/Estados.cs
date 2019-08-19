namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class Estados : IEntity
    {
        public int id { get; set; }
        public string estado { get; set; }
    }
}
