namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    using System;

    public class Personas : IEntity
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
    }
}
