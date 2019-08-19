namespace MigracionGym.Data
{
    using MigracionGym.Web.Data.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Entity : IEntity
    {
        public int id { get; set; }
    }
}
