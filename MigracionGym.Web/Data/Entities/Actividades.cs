using System.Collections.Generic;

namespace MigracionGym.Web.Data.Entities
{
    public class Actividades
    {
        public int Id { get; set; }
        private string Actividad { get; set; }
        private Profesores profesores { get; set; }

    }
}
