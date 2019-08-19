namespace MigracionGym.Web.Data.Entities
{

using MigracionGym.Data;

    public class EstadoCivil : IEntity
    {
        public int id { get; set; }
        private EstadoCivil estadoCivil { get; set; }
        private Personas personas { get; set; }
    }
}
