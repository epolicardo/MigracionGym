﻿namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    public class Provincias : IEntity
    {
        public int id { get; set; }

        public string nombre { get; set; }
    }
}
