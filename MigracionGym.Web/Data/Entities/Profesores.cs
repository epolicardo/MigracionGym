namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class Profesores : IEntity
    {
        public int id { get; set; }

        public Personas personas;
    }
}