namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class ActividadesSociosTurnos : IEntity
    {
        public int id { get; set; }
        private Socios socio { get; set; }
        private Relaciones relacion { get; set; }
        private int pases { get; set; }
        private int paseLibre { get; set; }

    }
}
