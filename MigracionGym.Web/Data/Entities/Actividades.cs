namespace MigracionGym.Web.Data.Entities
{
    using System;
    using MigracionGym.Data;

    public class Actividades : IEntity
    {
        public int id { get; set; }      
        public string actividad { get; set; }
        public Profesores profesores { get; set; }

    }
}
