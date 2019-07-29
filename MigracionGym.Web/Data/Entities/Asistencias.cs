namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;

    public class Asistencias : IEntity
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public Asistencias asistencia { get; set; }
        public Actividades actividad { get; set; }

    }
}
