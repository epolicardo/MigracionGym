using MigracionGym.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionGym.Web.Data.Entities
{
    public class EstadoCivil : IEntity
    {
        public int Id { get; set; }
        private string estadoCivil { get; set; }
        private Personas personas { get; set; }
    }
}
