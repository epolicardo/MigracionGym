namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class Horarios : IEntity
    {
        public int id { get; set; }
        private string horario { get; set; }
        private string dia { get; set; }
    }
}
