namespace MigracionGym.Web.Data.Entities
{
    using System;
    using MigracionGym.Data;

    public class Actividades : IEntity
    {
        public int id { get; set; }      
        private string actividad { get; set; }
        private Profesores profesores { get; set; }

    }
}
