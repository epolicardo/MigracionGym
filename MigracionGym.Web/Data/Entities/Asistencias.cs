namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Asistencias : IEntity
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public Asistencias asistencia { get; set; }
        public Actividades actividad { get; set; }

    }
}
