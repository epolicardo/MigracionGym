using MigracionGym.Data.Entities;
namespace MigracionGym.Web.Data.Entities
{
    using System;

    public class Cheques : IEntity
    {
        public int Id { get; set; }
        public Clientes idCliente { get; set; }
        public string Banco { get; set; }
        public string Plaza { get; set; }
        public DateTime FechaCobro { get; set; }
        public decimal Importe { get; set; }
    }
}
